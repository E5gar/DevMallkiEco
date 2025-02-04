using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultimosEnemigos : MonoBehaviour
{
    public GameObject a1ultimo;
    public GameObject a2ultimo;

    private void Start() {
        a1ultimo.SetActive(false);
        a2ultimo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("personaje")){
            a1ultimo.SetActive(true);
            a2ultimo.SetActive(true);
        }

        Destroy(gameObject);
    }

}
