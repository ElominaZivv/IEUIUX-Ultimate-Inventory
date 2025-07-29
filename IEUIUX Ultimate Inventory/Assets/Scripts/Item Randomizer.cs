using UnityEngine;
using System.Collections.Generic;

public class ItemRandomizer : MonoBehaviour
{
    // Haha
    [SerializeField] private Sprite item1; 
    [SerializeField] private Sprite item2; 
    [SerializeField] private Sprite item3; 
    [SerializeField] private Sprite item4; 
    [SerializeField] private Sprite item5; 
    [SerializeField] private Sprite item6; 
    [SerializeField] private Sprite item7; 
    [SerializeField] private Sprite item8; 
    [SerializeField] private Sprite item9; 
    [SerializeField] private Sprite item10;

    [Header("Managers")]
    [SerializeField] private GameObject inventoryManager;
    [SerializeField] private GameObject chestManager;

    private List<ItemData> itemOptions = new List<ItemData>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitializeRandomizer();
    }

    // Haha part 2
    private void InitializeRandomizer()
    {
        itemOptions.Add(MakeItem("Blue Top", "A frilly light blue top that will boost your damage!", item1));
        itemOptions.Add(MakeItem("Sleek Jacket", "A cool and trendy jacket to up your defense.", item2));
        itemOptions.Add(MakeItem("Fluffy Sweater", "This yellow sweater is pretty and practical.", item3));
        itemOptions.Add(MakeItem("Magical Dress", "A mysterious dress that boosts magic damage.", item4));
        itemOptions.Add(MakeItem("Hardy Boots", "A reliable pair of boots.", item5));
        itemOptions.Add(MakeItem("Cool Necklace", "These orange pendants light up with fire magic.", item6));
        itemOptions.Add(MakeItem("Silly Hat", "This hat makes you more intelligent. Or something.", item7));
        itemOptions.Add(MakeItem("Pretty Sundress", "Some may oppose to calling it a sundress.", item8));
        itemOptions.Add(MakeItem("Plain Scarf", "This plain white scarf has seen better days.", item9));
        itemOptions.Add(MakeItem("Worn Shoes", "Well-worn shoes that make you run faster!", item10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private ItemData MakeItem(string name, string desc, Sprite img)
    {
        ItemData item = new ItemData();
        item.itemName = name;
        item.itemDesc = desc;
        item.itemImage = img;

        return item;
    }

    // Makes a NEW item. Use this whenever you want a new object spawned
    private ItemData MakeNewItem()
    {
        ItemData item = new ItemData();
        int index = Random.Range(0, itemOptions.Count);

        item.itemName = itemOptions[index].itemName;
        item.itemDesc = itemOptions[index].itemDesc;
        item.itemImage = itemOptions[index].itemImage;

        return item;
    }

    public ItemData GetRandomItem()
    {
        return itemOptions[Random.Range(0, itemOptions.Count)];
    }

    public void AddToInventory()
    {
        inventoryManager.GetComponent<InventoryManager>().AddToInventory(MakeNewItem());
    }

    public void AddToInventory(int index)
    {
        inventoryManager.GetComponent<InventoryManager>().AddToInventory(MakeNewItem());
    }

    public void AddToChest()
    {
        chestManager.GetComponent<InventoryManager>().AddToInventory(MakeNewItem());
    }
}
