using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public List<List<GameObject>> slots;

    // Start is called before the first frame update
    void Start()
    {
        slots = new List<List<GameObject>>();
        for (int i = 0; i < 4; i++)
        {
            slots.Add(new List<GameObject>());
        }
        //Column
        for (int i = 0; i < 4; i++)
        {
            //Row
            for (int j = 0; j < 5; j++)
            {
                slots[i].Add(null);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AttemptOccupySlot(int column, int row, GameObject item)
    {
        if (slots[column][row] == null)
        {
            slots[column][row] = item;
            return true;
        }
        return false;
    }

    public List<List<GameObject>> GetSlots()
    {
        return slots;
    }
}
