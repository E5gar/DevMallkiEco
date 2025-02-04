using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemMovible : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("Inicia");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData){
        Debug.Log("Arrastra");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("Fin");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}