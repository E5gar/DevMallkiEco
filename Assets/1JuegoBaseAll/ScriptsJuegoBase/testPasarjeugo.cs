using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPasarjeugo : MonoBehaviour
{
    public bool pasóeljuego = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("personaje")){
        pasareljuegoBool();
        Debug.Log("El estado de pasar el juego es" + pasóeljuego);
        }
    }

    public void pasareljuegoBool(){
        pasóeljuego = true;
        PlayerPrefs.SetInt("terminóeljuego", (pasóeljuego ? 1 : 0));

    }
}
