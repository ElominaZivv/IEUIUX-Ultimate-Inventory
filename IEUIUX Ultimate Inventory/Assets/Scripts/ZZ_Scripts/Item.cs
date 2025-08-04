using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public ItemCategory itemCategory;

    [Header("UI")]
    public bool stackable = true;
}

public enum ItemCategory
{
    Armour, Weapon, Potion
}
