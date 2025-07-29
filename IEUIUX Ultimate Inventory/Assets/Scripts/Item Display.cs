using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] public GameObject itemName;
    [SerializeField] public GameObject itemDesc;
    [SerializeField] public GameObject itemImage;

    public string strName;
    public string strDesc;
    public Sprite spriteImage;

    [SerializeField] ItemData itemData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strName = itemName.GetComponent<TextMeshProUGUI>().text;
        strDesc = itemDesc.GetComponent<TextMeshProUGUI>().text;
        spriteImage = itemImage.GetComponent<Image>().sprite;  
    }

    // Update is called once per frame
    void Update()
    {
        strName = itemData.itemName;
        strDesc = itemData.itemDesc;
        spriteImage = itemData.itemImage;
        change();
    }

    private void change()
    {
        itemName.GetComponent<TextMeshProUGUI>().text = strName;
        itemDesc.GetComponent<TextMeshProUGUI>().text = strDesc;
        itemImage.GetComponent<Image>().sprite = spriteImage;
    }
}
