using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajasonidoganarjefe : MonoBehaviour
{
    public AudioSource sonidoGanarAlJefe;
    public GameObject cajaMusicaGanar;
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("personaje")) {
            sonidoGanarAlJefe.Play();
            cajaMusicaGanar.SetActive(false);
        }}
}
