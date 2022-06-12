/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {
    public InventorySlider gameManager;
    //public InventoryManager inventoryManager;
    public ItemStorage itemStorage;

    public void OnDrop(PointerEventData eventData) {
        print("Do I start here: OnDrop ItemSlot");


        if (eventData.pointerDrag != null ) {
            
            /*
                
            bool occupationSuccessful = false;

            switch(this.gameObject.name)
            {
                case "Inventory Square 1":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(0, 0, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 2":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(0, 1, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 3":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(0, 2, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 4":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(0, 3, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 5":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(0, 4, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 6":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(1, 0, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 7":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(1, 1, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 8":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(1, 2, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 9":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(1, 3, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 10":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(1, 4, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 11":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(2, 0, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 12":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(2, 1, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 13":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(2, 2, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 14":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(2, 3, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 15":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(2, 4, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 16":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(3, 0, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 17":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(3, 1, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 18":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(3, 2, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 19":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(3, 3, eventData.pointerDrag.gameObject);
                    break;
                case "Inventory Square 20":
                    occupationSuccessful = inventoryManager.AttemptOccupySlot(3, 4, eventData.pointerDrag.gameObject);
                    break;
            }
            if (occupationSuccessful)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                //Nuclear option:
                //eventData.pointerDrag.SetActive(false);
                //Too early to do that:
                //eventData.pointerDrag.GetComponent<BoxCollider2D>().enabled = false;
            }
            
            else
            {
                eventData.pointerDrag.GetComponent<DragDrop>().returnToStart();
            }
            */
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            gameManager.SetPreviousPosition(this.gameObject);
            //This hides the object
            //eventData.pointerDrag.SetActive(false);
        }
        else
        {
            eventData.pointerDrag.GetComponent<DragDrop>().returnToStart();
        }
        
        
    }

    
}
