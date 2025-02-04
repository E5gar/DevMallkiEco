using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject proyectil;
    [SerializeField] private float cooldown = 0.8f; 
    private float tiempoUltimoDisparo = 0f;

    public void Disparar(){
        if (Time.time > tiempoUltimoDisparo + cooldown) {
            Instantiate(proyectil, controladorDisparo.position, controladorDisparo.rotation);
            tiempoUltimoDisparo = Time.time; 
        }
    }
}