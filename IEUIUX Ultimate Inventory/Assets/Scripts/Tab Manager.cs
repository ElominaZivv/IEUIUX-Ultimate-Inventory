using UnityEngine;

public class TabManager : MonoBehaviour
{
    [SerializeField] GameObject tab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTab()
    {
        GameObject newItem = Instantiate(tab);

        newItem.transform.SetParent(transform, false);
    }
}
