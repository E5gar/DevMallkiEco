using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PreguntasManager : Singleton<PreguntasManager>
{
    public static Action AlCargarLaNuevaPregunta;
    public static Action SeHaRespondido;

    public PreguntaUI Pregunta;
    public string _CategoriaActual;
    private GameManager _gameManager;
    private ModeloPreguntas _actualpregunta;

    public Transform ImagenCorrecta;
    public Transform ImagenIncorrecta;

   private void Start(){
    _gameManager = GameManager.Instance;
    _CategoriaActual = _gameManager.ObtenerCategoriaActual();

    CargarSiguientePregunta();

   }

    void CargarSiguientePregunta(){
        _actualpregunta = _gameManager.GetQuestionForCategory(_CategoriaActual);
        if(_actualpregunta != null){
            Pregunta.VariasPreguntas(_actualpregunta);
        }
        AlCargarLaNuevaPregunta?.Invoke();
    }

    public bool ResponderAPregunta(int respuestaIndex){
        
        SeHaRespondido?.Invoke();

        bool harespondidobien = _actualpregunta.RespuestaCorrecta == respuestaIndex;

        if(harespondidobien){
            TweenResultado(ImagenCorrecta);
        }
        else{
            TweenResultado(ImagenIncorrecta);
        }
        return harespondidobien;
    }

    private void TweenResultado(Transform resultadoTransform){
        Sequence resultado = DOTween.Sequence();
        resultado.Append(resultadoTransform.DOScale(1,0.5f).SetEase(Ease.OutBack));
        resultado.AppendInterval(1f);
        resultado.Append(resultadoTransform.DOScale(0,0.3f).SetEase(Ease.Linear));
        resultado.AppendCallback(CargarSiguientePregunta);
    }

}

