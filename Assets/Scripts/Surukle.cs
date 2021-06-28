using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Surukle : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public bool isin;
    public bool Boyut;
    public void OnBeginDrag(PointerEventData eventData)
    {
        isin = true;
        if (Boyut)
        {
            gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
            gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal , 100);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isin = false;
    }

}