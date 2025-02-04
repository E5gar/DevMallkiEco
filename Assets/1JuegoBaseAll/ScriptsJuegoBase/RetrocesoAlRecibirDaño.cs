using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrocesoAlRecibirDaño : MonoBehaviour
{
    public Rigidbody2D jugadorRb;
    public float FuerzaRetroceso;
    public float ContarEfecto;
    public float TiempoTotalEfecto;

    public bool RetrocesoADerecha;


    void FixedUpdate() {
        if (ContarEfecto <= 0){

        } else{
            if(RetrocesoADerecha == true){
                jugadorRb.velocity = new Vector2(-FuerzaRetroceso, FuerzaRetroceso);
            }
            if(RetrocesoADerecha == false){
                jugadorRb.velocity = new Vector2(FuerzaRetroceso, FuerzaRetroceso);
            }

            ContarEfecto -= Time.deltaTime;

        }
    }
}
