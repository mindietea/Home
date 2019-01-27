using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class MouseFocusFadeScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        gameObject.GetComponent<CanvasGroup>().alpha = 1.0f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        gameObject.GetComponent<CanvasGroup>().alpha = 0.5f;
    }
}
