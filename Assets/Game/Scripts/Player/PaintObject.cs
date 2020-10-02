using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PaintObject : MonoBehaviour, IPointerEnterHandler
{
    private PaintModel data;
    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeCursor.ChangeCursorImage(data);
    }
}
