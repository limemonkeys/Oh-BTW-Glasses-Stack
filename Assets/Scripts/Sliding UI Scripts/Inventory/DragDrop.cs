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
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas = null;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;
    private Vector3 startingSize;

    private bool isValidPosition;
    private bool isEquipmentSlot;

    public ItemStorage itemStorage;

    void Start()
    {
        startingSize = transform.localScale;
    }
    
    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
        startPosition = transform.position;
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData) {
        print("Do I start here: OnDrop DragDrop");
    }

    public void OnEndDrag(PointerEventData eventData) {

        print("Do I start here: OnEndDrag DragDrop");
        print("eventData.pointerDrag.tag: " + eventData.pointerDrag.tag);

        if (!isValidPosition)
        {
            transform.position = startPosition;
        }
        else
        {
            
            //Not the issue

            if (isEquipmentSlot) 
            {
                if (itemStorage.GetItems().Count > 0)
                {
                    /*
                    foreach (GameObject glasses in itemStorage.GetItems())
                    {
                        glasses.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    */
                }

                transform.localScale = new Vector3(100, 100, 1);
                itemStorage.PushItem(eventData.pointerDrag.gameObject);
            }
            else
            {
                /*
                if (itemStorage.GetItems().Count > 0)
                {
                    itemStorage.GetItems()[itemStorage.GetItems().Count - 1].GetComponent<BoxCollider2D>().enabled = true;
                }
                */


                transform.localScale = startingSize;
                itemStorage.PopItem(eventData.pointerDrag.gameObject);

                /*
                if (itemStorage.GetItems().Count > 0)
                {
                    itemStorage.GetItems()[itemStorage.GetItems().Count - 1].GetComponent<BoxCollider2D>().enabled = true;
                }
                */
            }
        }

        
        
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData) {

    }

    public void returnToStart()
    {
        transform.position = startPosition;
    }


    public bool GetIsValidPosition()
    {
        return (isValidPosition);
    }

    public void SetIsValidPosition(bool isValidPosition)
    {
        this.isValidPosition = isValidPosition;
    }

    public void SetIsEquipmentSlot(bool isEquipmentSlot)
    {
        this.isEquipmentSlot = isEquipmentSlot;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
    
        if(other.name == "Equip Slot")
        {
            SetIsEquipmentSlot(true);
        }
        if((other.name.Split(" ")[0] == "Inventory" || other.name == "Equip Slot"))
        {
            SetIsValidPosition(true);
        }
        else
        {
            SetIsValidPosition(false);
        }
        
    }   

    void OnTriggerExit2D (Collider2D other)
    {
        SetIsEquipmentSlot(false);
        SetIsValidPosition(false);
    }
}
