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

public class ItemSlotEquip : MonoBehaviour, IDropHandler {

    public ItemStorage itemStorage;
    public string previousPosition;
    public InventorySlider gameManager;
    public DragDrop dragDrop;

    public void OnDrop(PointerEventData eventData) {
        print("Do I start here: OnDrop ItemSlotEquip");

        if (eventData.pointerDrag != null) {

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }

        gameManager.SetPreviousPosition(this.gameObject);
    }
}
