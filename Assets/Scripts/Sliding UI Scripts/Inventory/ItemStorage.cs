using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class ItemStorage : MonoBehaviour
{
    public List<GameObject> Items;
    public TextMeshProUGUI itemStorage;

    public PostProcessVolume Volume;
    public ColorGrading ColorGrading;

    public Color32 hueColor;
    public Image Hue;

    public Image shutter1;
    public Image shutter2;
    public Image shutter3;
    public Image shutter4;
    public Image shutter5;

    public Image gronchoEyebrows;
    public Image gronchoNose;

    // Start is called before the first frame update
    void Start()
    {
        Volume.profile.TryGetSettings(out ColorGrading);
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
        if (shades == 0 && purple == 0 && alien == 0 && fire == 0 && groncho == 0 && shutter == 0)
        {
            buffText += "None.";
        }

        if (shades > 0)
        {
            // Increase speed                
            //buffText += shades + " Shades \n";
            buffText += "• Speed increased (x" + shades + ")\n";
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -30f * (float)((Mathf.Log(shades)/1.2) + 1.75); 
        }
        else
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = 0f; 
        }
        
        
        if (purple > 0)
        {
            hueColor = new Color32(102,0,255, (byte) Mathf.Min((float) 42.5 * purple, 170f));
            // RGB Purple: 216, 191, 216
            // Increase jump
            //buffText += purple + " Purple \n";
            buffText += "• Jump height increased (x" + purple + ")\n";
        }
        if (alien > 0)
        {
            hueColor = new Color32(0, 0, 255, (byte) Mathf.Min((float) 42.5 * alien, 170f));
            // RGB Blue: 0, 0, 255
            // Increase slide speed
            //buffText += alien + " Alien \n";
            buffText += "• Slide distance increased (x" + alien + ")\n";
        }
        if (fire > 0)
        {
            hueColor = new Color32(255, 0, 0, (byte) Mathf.Min((float) 42.5 * fire, 170f));

            // RGB Blue: 255, 0, 0
            // Increase slide distance
            //buffText += fire + " Fire \n";
            
            
            buffText += "• Slide speed increased (x" + fire + ")\n";
        }

        float gronchoScale = 2f;
        if (groncho > 0)
        {
            if (groncho == 2)
            {
                gronchoScale = 1.5f;
                
            }
            if (groncho == 1)
            {
                gronchoScale = 1f;
                
            }
            // Spawn less targets(?)
            //buffText += groncho + " Groncho \n";
            buffText += "• " + groncho + " less target(s) spawned.\n";
        }
        else
        {
            gronchoScale = 0f;
        }
        gronchoEyebrows.transform.localScale = new Vector3(gronchoScale, gronchoScale, 0f);
        gronchoNose.transform.localScale = new Vector3(gronchoScale, gronchoScale, 0f);

        float shutterScale = 2f;
        if (shutter > 0)
        {
            if (shutter == 2)
            {
                shutterScale = 1.5f;
                
            }
            if (shutter == 1)
            {
                shutterScale = 1f;
                
            }
            
            // Shave 5s off timer
            buffText += "• " + (shutter * 5) + " seconds off finish time.";
        }
        else
        {
            shutterScale = 0f;
        }
        shutter1.transform.localScale = new Vector3(1f, shutterScale, 0f);
        shutter2.transform.localScale = new Vector3(1f, shutterScale, 0f);
        shutter3.transform.localScale = new Vector3(1f, shutterScale, 0f);
        shutter4.transform.localScale = new Vector3(1f, shutterScale, 0f);
        shutter5.transform.localScale = new Vector3(1f, shutterScale, 0f);

        if (purple == 0 && alien == 0 && fire == 0)
        {
            Hue.enabled = false;
        }
        else
        {
            Hue.enabled = true;
        }

        if (purple > 0 && alien > 0 && fire > 0)
        {
            hueColor = new Color32(90,0,192, (byte) Mathf.Min((float) 42.5 * (purple + alien + fire), 170f));
            //Colour: rgb(118,48,182)
        }
        else if (purple > 0 && alien > 0)
        {
            hueColor = new Color32(108,96,236, (byte) Mathf.Min((float) 42.5 * (purple + alien), 170f));
            //Colour: rgb(108,96,236)
        }
        else if (purple > 0 && fire > 0)
        {
            hueColor = new Color32(179,0,128, (byte) Mathf.Min((float) 42.5 * (purple + fire), 170f));
            //Colour: rgb(236,96,108)
        }
        else if (alien > 0 && fire > 0)
        {
            hueColor = new Color32(128, 0, 128, (byte) Mathf.Min((float) 42.5 * (alien + fire), 170f));
            //Colour: rgb(128,0,128)
        }

        Hue.color = hueColor;
        itemStorage.text = buffText;
    }
}
