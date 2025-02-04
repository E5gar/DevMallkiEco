using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArcoírisOscuro : MonoBehaviour
{
    public Image image;
    public Color32[] colors;
    public float speed = 0.001f;

    public void Start()
    {
        image = GetComponent<Image>();
        colors = new Color32[7]
        {
            new Color32(0x2C, 0x08, 0x09, 0xFF), //2C0809
            new Color32(0x2B, 0x28, 0x07, 0xFF), //2B2807
            new Color32(0x0B, 0x2B, 0x07, 0xFF), //0B2B07
            new Color32(0x07, 0x2B, 0x28, 0xFF), //072B28
            new Color32(0x07, 0x09, 0x2B, 0xFF), //07092B
            new Color32(0x2B, 0x07, 0x2A, 0xFF), //2B072A
            new Color32(0x2B, 0x07, 0x1A, 0xFF), //2B071A
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