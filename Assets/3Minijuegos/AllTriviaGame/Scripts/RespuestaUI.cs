using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RespuestaUI : MonoBehaviour
{
    public int respuestaIndex;
    public SistemaPuntos sistemaPuntos;

    public Image RespuestaCorrecta;
    public Image RespuestaIncorrecta;

    private bool _puedeHacerclic = true;

    private void OnEnable() {
        PreguntasManager.AlCargarLaNuevaPregunta += ResetearValor;
        PreguntasManager.SeHaRespondido += RespuestaEnviada;

    }

    private void OnDisable() {
        PreguntasManager.AlCargarLaNuevaPregunta -= ResetearValor;
        PreguntasManager.SeHaRespondido -= RespuestaEnviada;
    }

    public void ClickAlResponder(){

if(_puedeHacerclic){

    bool resultado = PreguntasManager.Instance.ResponderAPregunta(respuestaIndex);
        if(resultado){
        RespuestaCorrecta.DOFade(1,.5f);
            Debug.Log("ContestóBien");
            sistemaPuntos.SumarPuntos();

        }
        else{
        RespuestaIncorrecta.DOFade(1,.5f);
            sistemaPuntos.QuitarPuntos();
            Debug.Log("ContestóMal");



    }}}

    void ResetearValor(){
        RespuestaCorrecta.DOFade(0,0.2f);
        RespuestaIncorrecta.DOFade(0,0.2f);
        _puedeHacerclic = true;
    }

    void RespuestaEnviada(){
        _puedeHacerclic = false;
    }

}
