using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    public AudioSource clipCheckP;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("personaje")){
            clipCheckP.Play();
            other.GetComponent<PlayerRespawn>().ReachedCheckpoint(transform.position.x, transform.position.y);
        }
    }
}
