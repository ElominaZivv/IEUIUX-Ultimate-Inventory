using NUnit.Framework.Interfaces;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] private GameObject inventoryButton;
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject chest;

    [SerializeField] private GameObject itemData;
    private ItemData itemDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemDisplay = itemData.GetComponent<ItemData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenInventory()
    {
        inventory.SetActive(true);
        inventoryButton.SetActive(false);
    }
    public void ToggleChest()
    {
        chest.SetActive(!chest.activeInHierarchy);
    }

    public void ActivateItemData(ItemData item)
    {
        itemDisplay.itemName = item.itemName;
        itemDisplay.itemImage = item.itemImage;
        itemDisplay.itemDesc = item.itemDesc;
        itemData.SetActive(true);  
    }
}
