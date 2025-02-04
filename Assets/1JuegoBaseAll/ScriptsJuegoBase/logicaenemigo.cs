using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaenemigo : MonoBehaviour
{
    public gameManager gameManager;
    public RetrocesoAlRecibirDaño movimientoJugador;

    private void OnCollisionEnter2D(Collision2D conPersonaje) {
        if(conPersonaje.gameObject.CompareTag("personaje")){
            movimientoJugador.ContarEfecto = movimientoJugador.TiempoTotalEfecto;
            
            if(conPersonaje.transform.position.x <= transform.position.x){
                movimientoJugador.RetrocesoADerecha = true;
            }

            if(conPersonaje.transform.position.x > transform.position.x){
                movimientoJugador.RetrocesoADerecha = false;
            }

            gameManager.PierdeUnaVida();
        }
    }

    [SerializeField] private float vida;

    public void TomarDaño(float daño){
        vida -= daño;
        if(vida <= 0){
            Muerte();
        }

        Debug.Log("El enemigo ha recibido " + daño + " puntos de daño. Vida restante: " + vida);
    }

    private void Muerte(){
        Destroy(gameObject);
    }
}
