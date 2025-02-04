using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverpersonaje : MonoBehaviour
{
   bool esIzquierda = false;
   bool esDerecha = false;
   bool esSalto = false;
   bool puedeSaltar = true;

   public Rigidbody2D rb;
   public float velocidad;
   public float saltofuerza;

   public AudioSource sonidoSalto;


   public void clickIzquierda(){
        esIzquierda = true;
        transform.eulerAngles = new Vector3(0, esIzquierda ? 180 : 0, 0);
   }
    public void sueltaIzquierda(){
        esIzquierda = false;
    }

    public void clickDerecha(){
        esDerecha = true;
        transform.eulerAngles = new Vector3(0, esDerecha ? 0 : 0, 0);
   }
    public void sueltaDerecha(){
        esDerecha = false;
    }

    public void clickSalto(){
        esSalto = true;
    }

    private void FixedUpdate(){
        if (esIzquierda){
            rb.AddForce(new Vector2(-velocidad,0)* Time.deltaTime);
        }

        if (esDerecha){
            rb.AddForce(new Vector2(velocidad,0)* Time.deltaTime);
        }

        if (esSalto && puedeSaltar){
            esSalto = false;
            rb.AddForce(new Vector2(0,saltofuerza));
            puedeSaltar = false;
            sonidoSalto.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "suelo" || collision.gameObject.tag == "PlataformaTag"){
            puedeSaltar = true;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag =="PlataformaTag"){
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag =="PlataformaTag"){
            transform.parent = null;
        }
    }
}