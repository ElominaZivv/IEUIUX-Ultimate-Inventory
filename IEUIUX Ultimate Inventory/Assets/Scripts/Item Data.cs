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
       
    }

    public void PickUp()
    {
        GameObject.Find("Main Manager").GetComponent<MainManager>().ActivateItemData(this);
    }
}
