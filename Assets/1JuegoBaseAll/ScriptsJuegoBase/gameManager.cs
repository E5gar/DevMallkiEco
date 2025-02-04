using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] Vidas;
    private int cantidadVidas = 3;
    public pausaManager pausaManager;
    public AudioSource sonidoPerderVida;

    public void PierdeVida(int indice){
        Vidas[indice].SetActive(false);
    }

    public void PierdeTodaslasVidas(){
    foreach(GameObject vida in Vidas){
        vida.SetActive(false);
    }}

    public void RecuperaVida(int indice){
        Vidas[indice].SetActive(true);
    }

    public void PierdeUnaVida(){
        sonidoPerderVida.Play();
        cantidadVidas = cantidadVidas - 1;
        if(cantidadVidas == 0){
            Invoke("ReiniciarDespuesDeMedioSegundo", 0.5f);
        }
        PierdeVida(cantidadVidas);
    }

        private void ReiniciarDespuesDeMedioSegundo(){
            pausaManager.Reiniciar();
        }

    public void FueraDelMapa(){
        PierdeTodaslasVidas();
        Invoke("EsperaDeSegundo", 0.5f);
    }

    private void EsperaDeSegundo()
    {
        pausaManager.Reiniciar();
    }

    public bool RecuperaUnaVida(){
            if(cantidadVidas == 3){
                return false;
            }

        cantidadVidas = cantidadVidas + 1;
        RecuperaVida(cantidadVidas - 1);
        return true;
    }
}
