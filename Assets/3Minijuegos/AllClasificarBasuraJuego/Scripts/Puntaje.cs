using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos = 1922;
    private TextMeshProUGUI textMesh;

    public TextMeshProUGUI ResultadoAño;
    public TextMeshProUGUI ResultadoGotas;
    public GameObject CandadoGota1, CandadoGota2, CandadoGota3;

    public AudioSource sonidoGota;
    public AudioSource audioSource;
    public float speed = 0.40f;

    public int estadosRestantesTotal = 5;

    public GameObject[] estadoRio;

    public GameObject MenuResultados;
    public GameObject DesechosTotales, TachosTotales;

    public float gotasClasificar;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        gotasClasificar = PlayerPrefs.GetFloat("gotasClasificar");
        Debug.Log("Tienes " + gotasClasificar + " de las 3");

        MenuResultados.SetActive(false);

        CandadoGota1.SetActive(true);
        CandadoGota2.SetActive(true);
        CandadoGota3.SetActive(true);

    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
        textMesh.text = "Año " + puntos.ToString("0");

        if (puntos == 1999)
        {
            if (gotasClasificar < 1)
            {
                gotasClasificar += 1;
                PlayerPrefs.SetFloat("gotasClasificar", gotasClasificar);
                Debug.Log("¡Obtuviste una gota de agua!");
                Debug.Log("Tienes " + gotasClasificar + " de las 3");
                sonidoGota.Play();
            }
        }
        else if (puntos == 2009)
        {
            if (gotasClasificar < 2)
            {
                gotasClasificar += 1;
                PlayerPrefs.SetFloat("gotasClasificar", gotasClasificar);
                Debug.Log("¡Obtuviste una gota de agua!");
                Debug.Log("Tienes " + gotasClasificar + " de las 3");
                sonidoGota.Play();
            }
        }
        else if (puntos == 2023)
        {
            if (gotasClasificar < 3)
            {
                gotasClasificar += 1;
                PlayerPrefs.SetFloat("gotasClasificar", gotasClasificar);
                Debug.Log("¡Obtuviste una gota de agua!");
                Debug.Log("Tienes " + gotasClasificar + " de las 3");
                sonidoGota.Play();

            }
        }
    }

    public void ActivarEstados(int indice)
    {
        estadoRio[indice].SetActive(true);
    }

    public void PerderEstado()
    {
        estadosRestantesTotal -= 1;
        Debug.Log("Cantidad de estados: " + estadosRestantesTotal);
        ActivarEstados(estadosRestantesTotal);

        if (estadosRestantesTotal == 0)
        {
            MenuResultados.SetActive(true);
            DesechosTotales.SetActive(false);
            TachosTotales.SetActive(false);

            if(gotasClasificar >= 1){
                CandadoGota1.SetActive(false);
            }
            if(gotasClasificar >= 2){
                CandadoGota2.SetActive(false);
            }
            if(gotasClasificar >= 3){
                CandadoGota3.SetActive(false);
            }

            //Resultados
            ResultadoAño.text = "LLEGASTE HASTA EL AÑO " + puntos.ToString("0");
            ResultadoGotas.text = "Recolectaste " + gotasClasificar + " de las 3 gotas de agua disponibles en este minijuego";


            audioSource.pitch = speed;

            // Fin del juego, mostrar menú de resultados 
        }
    }
}
