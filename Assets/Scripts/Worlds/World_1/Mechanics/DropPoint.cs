using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPoint : MonoBehaviour, IDropHandler
{
    public int currentValue;
    public bool dropped;

    public void OnDrop(PointerEventData eventData)
    {
        void Clone()
        {
            GameObject clone = Instantiate(eventData.pointerDrag.GetComponent<AddValues>().gameObj, eventData.pointerDrag.GetComponent<AddValues>().position, Quaternion.identity) as GameObject;
            clone.transform.SetParent(eventData.pointerDrag.GetComponent<DragAndDrop>().canvas.transform, false);
            clone.GetComponent<DragAndDrop>().canvasGroup.alpha = 1f;
            clone.GetComponent<DragAndDrop>().canvasGroup.blocksRaycasts = true;
        }

        if (eventData.pointerDrag != null)
        {
            Clone();
            Destroy(eventData.pointerDrag.gameObject);    
            currentValue += eventData.pointerDrag.GetComponent<AddValues>().value;           
        }
    }
}