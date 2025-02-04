using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotsInventario : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData){
        if (transform.childCount == 0){
        GameObject dropped = eventData.pointerDrag;
        ItemMovible itemMovible = dropped.GetComponent<ItemMovible>();
        itemMovible.parentAfterDrag = transform;
    }}
}
