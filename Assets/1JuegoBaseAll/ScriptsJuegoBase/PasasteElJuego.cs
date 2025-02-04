using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PasasteElJuego : MonoBehaviour
{

    public GameObject primeraFase;
    public GameObject segundaFase;
    public GameObject terceraFase;
    public GameObject cuartaFase;
    public GameObject quintaFase;
    public GameObject sextaFase;

    public GameObject barraJefe;
    public GameObject spriteJefe;

    public Camera gameCamera;
    public Camera gameCameraBoss;
    public ControlAudio controlAudio;
    public aparecerDesvanecer aparecerdesvanecer;
    public GameObject cajaMusicaGanar;
    public GameObject nuevosFondos;

private void Start() {
    aparecerdesvanecer = FindObjectOfType<aparecerDesvanecer>();
    cajaMusicaGanar.SetActive(false);
    nuevosFondos.SetActive(false);
}

    public void PasasteElJuegoA(){
            gameCamera.enabled = true;
            gameCameraBoss.enabled = false;

            controlAudio.VolumenNormal();
            aparecerdesvanecer.aparecerOrquidea();

            nuevosFondos.SetActive(true);
            cajaMusicaGanar.SetActive(true);

        QuitarEnemigosFin();
        DesactivarBarraAnimacion();
        DesvanecerJefe();
    }

    private void DesvanecerJefe(){
        Material spritematerial = spriteJefe.GetComponent<Renderer>().material;
        spritematerial.DOFade(0, 8f);
    }

    private void QuitarEnemigosFin(){
        primeraFase.transform.DOScale(0, 3.5f).OnComplete(() => primeraFase.SetActive(false));
        segundaFase.transform.DOScale(0, 3.5f).OnComplete(() => segundaFase.SetActive(false));
        terceraFase.transform.DOScale(0, 3.5f).OnComplete(() => terceraFase.SetActive(false));
        cuartaFase.transform.DOScale(0, 3.5f).OnComplete(() => cuartaFase.SetActive(false));
        quintaFase.transform.DOScale(0, 3.5f).OnComplete(() => quintaFase.SetActive(false));
        sextaFase.transform.DOScale(0, 3.5f).OnComplete(() => sextaFase.SetActive(false));
    }

    private void DesactivarBarraAnimacion(){
        barraJefe.transform.DOScaleX(0, 2f).OnComplete(() => barraJefe.SetActive(false));;
    }

    

}
