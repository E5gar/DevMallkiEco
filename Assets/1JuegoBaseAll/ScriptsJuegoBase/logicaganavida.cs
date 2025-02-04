using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaganavida : MonoBehaviour
{
    public gameManager gameManager;
    public AudioSource sonidoPower;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("personaje")){
            bool vidaRecuperada = gameManager.RecuperaUnaVida();
            if(vidaRecuperada){
                sonidoPower.Play();
                Destroy(this.gameObject);
            }
            
        }
    }
}
