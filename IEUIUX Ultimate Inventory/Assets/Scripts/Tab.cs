using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tab : MonoBehaviour
{
    [SerializeField] private GameObject deleteButton;
    public bool isSelected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void EnableDelete()
    {
        deleteButton.SetActive(isSelected);
    }

    public void Select()
    {
        isSelected = !isSelected;
        GetComponent<Animator>().SetBool("isSelected", isSelected);
    }
}
