using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimientoenX : MonoBehaviour
{
    public GameObject personaje;

    public bool seguir = true;
    
    void Update() {
        if (seguir) {
            Vector3 pos = transform.position;
            pos.x = personaje.transform.position.x;
            transform.position = pos;
        }
    }
}