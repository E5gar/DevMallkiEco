using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaPuntos : MonoBehaviour
{
    public int puntosTrivia = 0;
    public TextMeshProUGUI textoPuntos;
    public float CantidaRespuestasCorrectas = 0;
    public float CantidaRespuestasIncorrectas = 0;

    private void Start() {
        ActualizarTexto();
    }

    public void SumarPuntos(){
        puntosTrivia += 150;
        ActualizarTexto();
        CantidaRespuestasCorrectas = CantidaRespuestasCorrectas + 1;
    }

    public void QuitarPuntos(){
        puntosTrivia -= 30;
        ActualizarTexto();
        CantidaRespuestasIncorrectas = CantidaRespuestasIncorrectas + 1;
    }

    private void ActualizarTexto() {
        textoPuntos.text = "Puntaje " + puntosTrivia.ToString("0");
    }
}
