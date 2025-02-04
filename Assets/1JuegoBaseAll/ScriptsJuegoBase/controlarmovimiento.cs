/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarmovimiento : MonoBehaviour
{
    public float velocidad;
    public float fuerzaSalto;
    private new Rigidbody2D rigidbody;
    private bool mirarderecha = true;
    bool enElSuelo = true;
    float inputMovimiento = 0f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ProcesarMovimiento();
    }

    void ActualizarMovimiento(float direccion) {
        inputMovimiento = direccion;
    }

    public void MoverDerecha() {
        ActualizarMovimiento(6f);
    }

    public void MoverIzquierda() {
        ActualizarMovimiento(-6f);
    }

    public void DetenerMovimiento() {
        ActualizarMovimiento(0f);
    }

    public void ProcesarMovimiento()
    {
        rigidbody.velocity = new Vector2(inputMovimiento * velocidad * Time.deltaTime, rigidbody.velocity.y);
        CambiarHorientación(inputMovimiento);

        if (enElSuelo && Input.GetKeyDown(KeyCode.Space)) {
            enElSuelo = false;
            rigidbody.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    void CambiarHorientación(float inputMovimiento)
    {
        if (mirarderecha == true && inputMovimiento < 0 || mirarderecha == false && inputMovimiento > 0)
        {
            mirarderecha = !mirarderecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "suelo")
        {
            enElSuelo = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "suelo")
        {
            enElSuelo = false;
        }
    }
}*/