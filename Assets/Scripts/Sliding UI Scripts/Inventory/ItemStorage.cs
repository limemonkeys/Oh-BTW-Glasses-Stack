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
        UpdateList();
    }

    public void PopItem(GameObject item)
    {
        Items.Remove(item);
        UpdateList();
    }

    public List<GameObject> GetItems()
    {
        return Items;
    }

    public void UpdateList()
    {
        string buffText = "";
        int shades = 0;
        int purple = 0;
        int alien = 0;
        int fire = 0;
        int groncho = 0;
        int shutter = 0;
        foreach (GameObject glasses in Items)
        {
            switch (glasses.name)
            {
                case "Shades":
                    shades++;
                    break;
                case "Purple":
                    purple++;
                    break;
                case "Alien":
                    alien++;
                    break;            
                case "Fire":
                    fire++;
                    break;
                case "Groncho":
                    groncho++;
                    break;
                case "Shutter":
                    shutter++;
                    break;
            }
        }
        if (shades > 0)
        {
            // Increase speed
            buffText += shades + " Shades \n";
        }
        if (purple > 0)
        {
            // Increase jump
            buffText += purple + " Purple \n";
        }
        if (alien > 0)
        {
            // Increase slide speed
            buffText += alien + " Alien \n";
        }
        if (fire > 0)
        {
            // Increase slide distance
            buffText += fire + " Fire \n";
        }
        if (groncho > 0)
        {
            // Spawn less targets(?)
            buffText += groncho + " Groncho \n";
        }
        if (shutter > 0)
        {
            // Shave 5s off timer
            buffText += shutter + " Shutter";
        }
        itemStorage.text = buffText;
    }
}
