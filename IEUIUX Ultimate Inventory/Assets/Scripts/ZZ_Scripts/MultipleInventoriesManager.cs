using UnityEngine;

public class MultipleInventoriesManager : MonoBehaviour
{
    [SerializeField] GameObject[] InventoryWindows;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        for (int i = 0; i < InventoryWindows.Length; i++)
        {
            InventoryWindows[i].SetActive(false);
        }
        InventoryWindows[0].SetActive(true);
    }
    void Start()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.INVENTORY_NAVGIATE_CATEGORY, this.ChangeCategory);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.INVENTORY_NAVGIATE_CATEGORY);
    }

    void ChangeCategory(Parameters param)
    {
        int chosenCategoryIndex = param.GetIntExtra(ParamNames.CATEGORY_INDEX, 0);
        for (int i = 0; i < InventoryWindows.Length; i++)
        {
            InventoryWindows[i].SetActive(false);
        }
        InventoryWindows[chosenCategoryIndex].SetActive(true);
    }
    

}
