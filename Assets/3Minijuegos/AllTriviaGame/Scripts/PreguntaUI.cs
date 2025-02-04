using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PreguntaUI : MonoBehaviour
{
    public TextMeshProUGUI PreguntaFondo;

    public TextMeshProUGUI Respuesta1Fondo;

    public TextMeshProUGUI Respuesta2Fondo;

    public TextMeshProUGUI Respuesta3Fondo;

    public TextMeshProUGUI Respuesta4Fondo;

    public void VariasPreguntas(ModeloPreguntas modeloPreguntas){
        PreguntaFondo.text = modeloPreguntas.Pregunta;
        Respuesta1Fondo.text = modeloPreguntas.Respuesta1;
        Respuesta2Fondo.text = modeloPreguntas.Respuesta2;
        Respuesta3Fondo.text = modeloPreguntas.Respuesta3;
        Respuesta4Fondo.text = modeloPreguntas.Respuesta4;
    }

}
