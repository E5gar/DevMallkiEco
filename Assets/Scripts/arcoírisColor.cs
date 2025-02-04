using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arcoírisColor : MonoBehaviour
{
    public Image image;
    public Color32[] colors;
    public float speed = 0.001f;

    public void Start()
    {
        image = GetComponent<Image>();
        colors = new Color32[7]
        {
            new Color32(0xFF, 0xAC, 0xAC, 0xFF), //FFACAC
            new Color32(0xFF, 0xF8, 0xA5, 0xFF), //FFF8A5
            new Color32(0xC9, 0xFF, 0xAC, 0xFF), //C9FFAC
            new Color32(0xAA, 0xFF, 0xE1, 0xFF), //AAFFE1
            new Color32(0xAA, 0xBD, 0xFF, 0xFF), //AABDFF
            new Color32(0xD4, 0xA2, 0xFF, 0xFF), //D4A2FF
            new Color32(0xFF, 0xD0, 0xEF, 0xFF), //FFD0EF
        };
        StartCoroutine(CambiarColorDeFondo());
    }

    public IEnumerator CambiarColorDeFondo()
    {
        int i = 0;
        while (true)
        {
            for (float interpolant = 0f; interpolant < 1f; interpolant += speed)
            {
                image.color = Color.Lerp(colors[i % 7], colors[(i + 1) % 7], interpolant);
                yield return null;
            }
            i++;
        }
    }
}