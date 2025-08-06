using UnityEngine;

public class CategoryTabManager : MonoBehaviour
{
    [SerializeField] int categoryTabMax = 5;
    private int currentCategoryTabInstances = 0;
    public GameObject categoryPrefab;

    private void UpdateCurrentNumberTabInstances()
    {
        currentCategoryTabInstances = this.transform.childCount;
    }
    public void AddCategory()
    {
        UpdateCurrentNumberTabInstances();
        if (currentCategoryTabInstances < categoryTabMax)
        {
            Instantiate(categoryPrefab, this.transform);

            Transform newCategoryTabInstance = this.transform.GetChild(currentCategoryTabInstances);
            GameObject newCategoryTabGameObject = newCategoryTabInstance.gameObject;
            CategoryTab tabData = newCategoryTabGameObject.GetComponent<CategoryTab>();
            tabData.categoryTabID = currentCategoryTabInstances;
            UpdateCurrentNumberTabInstances();
        }
    }
}