using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.UIElements;
// using Microsoft.Unity.VisualStudio.Editor;

public class InventoryManager : MonoBehaviour
{
    private List<GameObject> allItems = new List<GameObject>();
    [SerializeField] GameObject inventoryCell;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToInventory(ItemData item)
    {
        GameObject newItem = Instantiate(inventoryCell);
        newItem.GetComponent<ItemData>().itemName = item.itemName;
        newItem.GetComponent<ItemData>().itemDesc = item.itemDesc;
        newItem.GetComponent<ItemData>().itemImage = item.itemImage;
        newItem.GetComponent<ItemData>().itemImageObj.GetComponent<UnityEngine.UI.Image>().sprite = item.itemImage;

        newItem.transform.SetParent(transform, false);

        allItems.Add(newItem);
    }
}
