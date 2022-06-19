using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracker : MonoBehaviour
{
    static int shades = 0;
    static int purple = 0;
    static int alien = 0;
    static int fire = 0;
    static int groncho = 0;
    static int shutter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Shades: " + shades);
    }

    public void SaveEquips(List<GameObject> Items)
    {
        int tempShades = 0;
        int tempPurple = 0;
        int tempAlien = 0;
        int tempFire = 0;
        int tempGroncho = 0;
        int tempShutter = 0;
        foreach (GameObject glasses in Items)
        {
            switch (glasses.name)
            {
                case "Shades":
                    tempShades++;
                    break;
                case "Purple":
                    tempPurple++;
                    break;
                case "Alien":
                    tempAlien++;
                    break;            
                case "Fire":
                    tempFire++;
                    break;
                case "Groncho":
                    tempGroncho++;
                    break;
                case "Shutter":
                    tempShutter++;
                    break;
            }
        }
        shades = tempShades;
        purple = tempPurple;
        alien = tempAlien;
        fire = tempFire;
        groncho = tempGroncho;
        shutter = tempShutter;
    }

    public int getShades()
    {
        return shades;
    }

    public int getPurple()
    {
        return purple;
    }

    public int getAlien()
    {
        return alien;
    }

    public int getFire()
    {
        return fire;
    }

    public int getGroncho()
    {
        return groncho;
    }

    public int getShutter()
    {
        return shutter;
    }
}
