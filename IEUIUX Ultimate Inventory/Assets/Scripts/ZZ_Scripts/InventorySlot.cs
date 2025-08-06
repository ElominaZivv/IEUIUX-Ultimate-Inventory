using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image image;
    public Color defaultColor, commonColor, uncommonColor, rareColor, epicColor, legendaryColor, mythicColor;

    private void Start()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.INVENTORY_ITEM_DRAG_DROP, this.UpdateBackgroundColor);
        EventBroadcaster.Instance.AddObserver(EventNames.INVENTORY_SLOT_UPDATE_BACKGROUND_COLOR, this.UpdateBackgroundColor);
    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.INVENTORY_ITEM_DRAG_DROP);
        EventBroadcaster.Instance.RemoveObserver(EventNames.INVENTORY_SLOT_UPDATE_BACKGROUND_COLOR);
    }

    private void UpdateBackgroundColor()
    {
        ItemRarity itemRarity;
        InventoryItem itemInSlot = this.GetComponentInChildren<InventoryItem>();
        if (itemInSlot!=null)
        {
            itemRarity = itemInSlot.item.itemRarity;
        }
        else
        {
            image.color = defaultColor;
            return;
        }

        // Common, Uncommon, Rare, Epic, Legendary, Mythic
        if (itemRarity == ItemRarity.Common)
        {
            image.color = commonColor;
        }
        else if (itemRarity == ItemRarity.Uncommon)
        {
            image.color = uncommonColor;
        }
        else if (itemRarity == ItemRarity.Rare)
        {
            image.color = rareColor;
        }
        else if (itemRarity == ItemRarity.Epic)
        {
            image.color = epicColor;
        }
        else if (itemRarity == ItemRarity.Legendary)
        {
            image.color = legendaryColor;
        }
        else if (itemRarity == ItemRarity.Mythic)
        {
            image.color = mythicColor;
        }
        else
        {
            image.color = defaultColor;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 1)
        {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            inventoryItem.parentAfterDrag = transform;
        }
    }
} 
