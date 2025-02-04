using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlbumManager : MonoBehaviour
{
    public List<GameObject> candados;
    public List<TextMeshProUGUI> textosDesbloqueo;
    public float cantidadGotasParaDesbloquear;
    public float cantidadGotasJuegoBase;
    public float cantidadGotasJuegoClasificar;

    void Start()
    {
        cantidadGotasJuegoBase += PlayerPrefs.GetFloat("gotasRecogidas");
        cantidadGotasJuegoClasificar += PlayerPrefs.GetFloat("gotasClasificar");

        cantidadGotasParaDesbloquear += cantidadGotasJuegoBase + cantidadGotasJuegoClasificar;


        Debug.Log("Tienes " + cantidadGotasParaDesbloquear + " gotas.");

        for (int i = 0; i < candados.Count; i++)
        {
            candados[i].SetActive(true);

            if (cantidadGotasParaDesbloquear >= i + 1)
            {
                candados[i].SetActive(false);

                string mensaje = "Se desbloquea con " + (i + 1) + " gotas, tienes " + cantidadGotasParaDesbloquear + ".";
                textosDesbloqueo[i].text = mensaje;
            }
            else
            {
                string mensaje = "Se desbloquea con " + (i + 1) + " gotas, tienes " + cantidadGotasParaDesbloquear + ".";
                textosDesbloqueo[i].text = mensaje;
            }
        }
    }
}
