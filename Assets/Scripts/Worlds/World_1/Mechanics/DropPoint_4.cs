using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPoint_4 : MonoBehaviour, IDropHandler
{
    private RectTransform rectTransform;
    public int currentValue = 0;
    public bool dropped;

    void Awake()
    {
        rectTransform = this.GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        void Clone()
        {
            GameObject clone = Instantiate(eventData.pointerDrag.GetComponent<AddValues>().gameObj, eventData.pointerDrag.GetComponent<AddValues>().position, Quaternion.identity) as GameObject;
            clone.transform.SetParent(GameObject.Find("Actividad_Base_3").transform, false);
            clone.GetComponent<DragAndDrop>().canvasGroup.alpha = 1f;
            clone.GetComponent<DragAndDrop>().canvasGroup.blocksRaycasts = true;
        }

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.rectTransform.anchoredPosition;
            Clone();
            currentValue = eventData.pointerDrag.GetComponent<AddValues>().value;           
        }
    }
}