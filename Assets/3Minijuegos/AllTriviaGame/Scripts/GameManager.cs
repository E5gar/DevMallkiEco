using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using TMPro;


public class GameManager : Singleton<GameManager>
{
    public ModeloJuego Configuración;
    private string _CategoriaActual;
    public GameObject resultadoMenu, menuJuego;
    public string TiempoTotal;
    
    public int Aminutos = 0;
    public int Asegundos = 0;

    public float ResultadoCorrectos;
    public TextMeshProUGUI AResultadoCorrectos;
    public float ResultadoIncorrectos;
    public TextMeshProUGUI AResultadoIncorrectos;

    public ContadorTiempo contadorTiempo;
    public SistemaPuntos sistemaPuntos;
    public TextMeshProUGUI tiempoResultados;
    public TextMeshProUGUI categoriaResultados;

    public int ApuntosTrivia = 0;
    public TextMeshProUGUI AAPuntosTrivia;
    public int FinalpuntosTrivia;
    public int BonusTiempo = 0;
    public bool findelJuego = false;

    public arcoírisColor arcoíriscolor;


    private List<int> _preguntaIndex = new List<int>();

    private void Start()
    {
        ApuntosTrivia = 0;
        FinalpuntosTrivia = 0;
        resultadoMenu.SetActive(false);
        contadorTiempo = FindObjectOfType<ContadorTiempo>();

        InvokeRepeating("ActualizarPuntos", 1.0f, 1.0f);
    }

    public ModeloPreguntas GetQuestionForCategory(string nombreCategoría)
    {
        ModeloCategorías categoríaModelo = Configuración.Categorías.FirstOrDefault(categoría => categoría.NombreCategoría == nombreCategoría);

        if (categoríaModelo != null)
        {
            int randomIndex = UnityEngine.Random.Range(0, categoríaModelo.Preguntas.Count);

            while (categoríaModelo.Preguntas.Count > _preguntaIndex.Count && _preguntaIndex.Contains(randomIndex))
            {
                randomIndex = UnityEngine.Random.Range(0, categoríaModelo.Preguntas.Count);
            }

            _preguntaIndex.Add(randomIndex);

            if (_preguntaIndex.Count == 11)
            {
                resultadoMenu.SetActive(true);
                menuJuego.SetActive(false);
                contadorTiempo.PausarContador();

                arcoíriscolor.StartCoroutine(arcoíriscolor.CambiarColorDeFondo());

                TiempoTotal = contadorTiempo.textoTiempo.text;
                tiempoResultados.text = TiempoTotal;

                ResultadoIncorrectos = sistemaPuntos.CantidaRespuestasIncorrectas;
                ResultadoCorrectos = sistemaPuntos.CantidaRespuestasCorrectas;

                AResultadoCorrectos.text = ResultadoCorrectos.ToString();
                AResultadoIncorrectos.text = ResultadoIncorrectos.ToString();

                Aminutos = Mathf.FloorToInt(contadorTiempo.minutos);
                Asegundos = Mathf.FloorToInt(contadorTiempo.segundos);

                ApuntosTrivia = sistemaPuntos.puntosTrivia;
                int tiempoTotalEnSegundos = Aminutos * 60 + Asegundos;

                BonusTiempo = 100 - tiempoTotalEnSegundos;

                FinalpuntosTrivia = ApuntosTrivia + BonusTiempo;

                //FinalpuntosTrivia = Mathf.RoundToInt((((ApuntosTrivia + (2 * ApuntosTrivia) / tiempoTotalEnSegundos) * 100f) / 100f) + UnityEngine.Random.Range(0, 100));
            }

            return categoríaModelo.Preguntas[randomIndex];
        }

        return null;
    }

    public void ActualizarPuntos(){
        AAPuntosTrivia.text = FinalpuntosTrivia.ToString();
        Debug.Log("PUNTOS SON: " + AAPuntosTrivia.text);
    }

    public void EstablecerCategoria(string nombreCategoría){
        _CategoriaActual = nombreCategoría;
        _preguntaIndex.Clear();

        categoriaResultados.text = _CategoriaActual;
    }

    public string ObtenerCategoriaActual(){
        return _CategoriaActual;
    }

}
