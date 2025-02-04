using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScrolling : MonoBehaviour
{
    [SerializeField] private RawImage imagen;
    [SerializeField] private float ax,ay;

private void Update() {
    imagen.uvRect = new Rect(imagen.uvRect.position + new Vector2(ax,ay) * Time.deltaTime, imagen.uvRect.size);
}

}
