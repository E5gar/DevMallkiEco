using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirAlPersonaje : MonoBehaviour
{
    public GameObject jugador;
    public bool voltear;
    public float velocidad;

    private void Update()
    {
        Vector3 escala = transform.localScale;

        if (jugador.transform.position.x > transform.position.x)
        {
            escala.x = Mathf.Abs(escala.x) * -1 * (voltear ? -1 : 1);
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }
        else
        {
            escala.x = Mathf.Abs(escala.x) * (voltear ? -1 : 1);
            transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }

        transform.localScale = escala;
    }
}