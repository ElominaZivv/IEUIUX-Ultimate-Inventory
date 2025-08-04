using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemInfoWindow : MonoBehaviour
{
    public Item item;
    public Sprite itemImage;
    public string itemName;
    public string itemCategory;

    [SerializeField] Image displayItemImage;
    [SerializeField] Text displayItemName;
    [SerializeField] Text displayItemCategory;


    private void Start()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.INVENTORY_ITEM_HOVER_ENTER, this.DisplayItemData);

        displayItemName.text = " ";
        displayItemCategory.text = " ";
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.INVENTORY_ITEM_HOVER_ENTER);
    }

    private void DisplayItemData(Parameters param)
    {
        item = param.GetItemExtra(ParamNames.ITEM_DATA);
        itemImage = item.image;
        itemName = item.name;
        itemCategory = item.itemCategory.ToString();
        RefreshDisplayData();
    }

    private void RefreshDisplayData()
    {
        displayItemImage.sprite = itemImage;
        displayItemName.text = itemName;
        displayItemCategory.text = itemCategory;
    }
}
