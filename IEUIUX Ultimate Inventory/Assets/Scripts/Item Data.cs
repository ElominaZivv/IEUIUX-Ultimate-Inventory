using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ItemData : MonoBehaviour
{
    [SerializeField] public string itemName;
    [SerializeField] public string itemDesc;
    [SerializeField] public Sprite itemImage;
    [SerializeField] public GameObject itemImageObj;

    private bool isHolding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding)
        {
            GetComponent<Transform>().position = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Release();
        }
    }

    public void PickUp()
    {
        Debug.Log("Held");
        isHolding=true;
        if (GetComponent<LayoutElement>() != null) GetComponent<LayoutElement>().ignoreLayout = true;
    }

    private void Release() {
        Debug.Log("Released");
        isHolding =false;
        if (GetComponent<LayoutElement>() != null) GetComponent<LayoutElement>().ignoreLayout = false;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Inventory")
    //    {
    //        inventoryManager.GetComponent<InventoryManager>().AddToInventory(MakeNewItem());
    //    }
    //}
}
