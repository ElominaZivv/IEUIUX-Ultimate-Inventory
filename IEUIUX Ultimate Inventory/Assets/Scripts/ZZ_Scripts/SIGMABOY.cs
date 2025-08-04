using UnityEngine;

public class SIGMABOY : MonoBehaviour
{
    public InventoryFunc invFunc;
    public Item[] collectedItems;

    public void collectItem(int id)
    {
        bool result = invFunc.AddItem(collectedItems[id]);
        /*
        if (result == true)
        {
            Debug.Log("Item Added");
        }
        else
        {
            Debug.Log("Inventory Full! Item NOT added");
        }
        */
    }
}
