using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemStorage : MonoBehaviour
{
    public List<GameObject> Items;
    public TextMeshProUGUI itemStorage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushItem(GameObject item)
    {
        Items.Add(item);
        string buffText = "";
        foreach (GameObject glasses in Items)
        {
            buffText += glasses.name + "\n";
        }
        itemStorage.text = buffText;
    }

    public void PopItem(GameObject item)
    {
        Items.Remove(item);
    }

    public List<GameObject> GetItems()
    {
        return Items;
    }
}
