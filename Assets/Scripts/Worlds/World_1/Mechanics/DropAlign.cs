using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropAlign : MonoBehaviour, IDropHandler
{
    private RectTransform rectTransform;
    public int currentValue = 0;

    void Awake()
    {
        rectTransform = this.GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.rectTransform.anchoredPosition;
            currentValue = eventData.pointerDrag.GetComponent<AddValues>().value;
        }
    }
}
