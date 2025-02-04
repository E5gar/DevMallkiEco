using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaLimite : MonoBehaviour
{

    [SerializeField] private Puntaje puntaje;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        float randomY = Random.Range(3.9f, 38.9f);
        Transform objeto = collision.gameObject.GetComponent<Transform>();
        objeto.position = new Vector2(0, randomY);

        Debug.Log("La caja límite ha chocado con " + collision.gameObject.name);
        puntaje.PerderEstado();
    }
}
