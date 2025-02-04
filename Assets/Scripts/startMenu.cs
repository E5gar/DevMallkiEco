using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{
    public AudioSource menuLoffi;
    public float cantidadGotas;
    public bool pasóeljuego;

    public GameObject botonBloqueo;

    private void OnEnable() {
        cantidadGotas += PlayerPrefs.GetFloat("gotasRecogidas");
        pasóeljuego = (PlayerPrefs.GetInt("terminóeljuego") != 0);

        menuLoffi.Play();
        Debug.Log("Estado de pasar el juego:" + pasóeljuego);

        if(pasóeljuego == true){
            botonBloqueo.SetActive(false);
        }
    }
}
