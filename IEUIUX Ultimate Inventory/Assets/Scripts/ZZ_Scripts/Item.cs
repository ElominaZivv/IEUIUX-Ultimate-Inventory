using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public string name;
    public ItemCategory itemCategory;
    public ItemRarity itemRarity;

    [Header("UI")]
    public bool stackable = true;
}

public enum ItemCategory
{
    Armour, Weapon, Potion
}
public enum ItemRarity
{
    Common, Uncommon, Rare, Epic, Legendary, Mythic
}

