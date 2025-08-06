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

    public void RandomizeItems()
    {
        int rand0 = Random.Range(3, 7);

        for (int i = 0; i < rand0; i++)
        {
            //Random Collected Item
            int rand1 = Random.Range(0,collectedItems.Length);

            //Random Amount
            int rand2 = Random.Range(1, 14);

            for (int j = 0; j < rand2; j++)
            {
                invFunc.AddItem(collectedItems[rand1]);
            }

        }
    }
}
