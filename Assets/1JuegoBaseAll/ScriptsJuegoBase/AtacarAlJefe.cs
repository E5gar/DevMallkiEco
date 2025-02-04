using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacarAlJefe : MonoBehaviour
{
    public saludJefeManager saludjefemanager;
    public AudioSource sonidoDañarJefe;

    private void Start() {
        saludjefemanager = FindObjectOfType<saludJefeManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "personaje")
        {
            saludjefemanager.JefeTomaDaño(20);
            sonidoDañarJefe.Play();
            Destroy(gameObject);
        }
    }
}
