using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerController : MonoBehaviour
{
    public Image contadortiempo;
    private float tiempoQueda;
    public List<float> tiemposMaximos = new List<float>{3.0f, 1.0f, 4.0f, 1.0f, 7.0f};
    private bool empiezaAContar = false;
    public int rondasCompletadas = 0;
    public int numRondasTotales = 5;

    private void Start() {
        tiempoQueda = tiemposMaximos[0];
        empiezaAContar = false;
    }

    public void ActivarCuentaAtras(){
        empiezaAContar = true;
    }

    private void Update() {
        if (empiezaAContar == true){
            if (tiempoQueda > 0){
                tiempoQueda -= Time.deltaTime;
                contadortiempo.fillAmount = tiempoQueda / tiemposMaximos[rondasCompletadas];
            }
            else {
                rondasCompletadas++;
                if (rondasCompletadas < numRondasTotales) {
                    tiempoQueda = tiemposMaximos[rondasCompletadas];
                } else {
                    empiezaAContar = false;
                }
                Debug.Log("Se acabó el tiempo");
            }
        }
    }
}