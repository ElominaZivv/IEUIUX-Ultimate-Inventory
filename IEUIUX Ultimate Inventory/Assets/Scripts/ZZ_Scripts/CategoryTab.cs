using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CategoryTab : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Button button;

    public int categoryTabID = -1;

    public bool isOpen = false;

    [SerializeField] GameObject categoryNameTextField;
    // private bool categoryNameTextFieldIsOpen = false;
    [SerializeField] Image image;
    public Sprite openedIcon;
    public Sprite closedIcon;
    public Color openedColor;
    public Color closedColor;

    private void Awake()
    {
        button = this.GetComponent<Button>();
    }
    void Start()
    {
        EventBroadcaster.Instance.AddObserver(EventNames.INVENTORY_NAVGIATE_CATEGORY, this.SetOpened);
        Initialize();
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.INVENTORY_NAVGIATE_CATEGORY);
    }

    private void Initialize()
    {
        UpdateSprite();
        categoryNameTextField.SetActive(false);
    }

    public void Pressed()
    {
        Parameters param = new Parameters();
        param.PutExtra(ParamNames.CATEGORY_INDEX, categoryTabID);
        EventBroadcaster.Instance.PostEvent(EventNames.INVENTORY_NAVGIATE_CATEGORY, param);
    }

    private void UpdateSprite()
    {

        if (isOpen)
        {
            image.sprite = openedIcon;
            image.color = openedColor;
        }
        else
        {
            image.sprite = closedIcon;
            image.color = closedColor;
        }
    }

    private void SetOpened(Parameters param)
    {
        int openedCategoryIndex = param.GetIntExtra(ParamNames.CATEGORY_INDEX, 0);

        if (openedCategoryIndex == categoryTabID)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }

        UpdateSprite();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // if (eventData.button == PointerEventData.InputButton.Right)
        // {
        //     categoryNameTextFieldIsOpen = !categoryNameTextFieldIsOpen;
        //     categoryNameTextField.SetActive(categoryNameTextFieldIsOpen);
        // }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        categoryNameTextField.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
            categoryNameTextField.SetActive(false);
    }
}
