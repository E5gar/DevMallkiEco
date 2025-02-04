using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fueradellimite : MonoBehaviour
{
    public gameManager gameManager;
    public AudioSource sonidoPerderVida;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("personaje")){
            gameManager.FueraDelMapa();
            sonidoPerderVida.Play();
        }
    }
}
