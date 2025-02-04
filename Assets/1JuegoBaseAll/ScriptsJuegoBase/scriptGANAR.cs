using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptGANAR : MonoBehaviour
{
    public ControlAudio controlAudio;
    public AudioSource ganarAudio;
    public GameObject menuGanar;
    public GameObject menuPausa;
    public TextMeshProUGUI textoganar;

    public float cantidadGotas;

    public bool pasóeljuego = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("personaje")){

            Debug.Log("TERMINÓ EL JUEGO");
            ganarAudio.Play();
            Debug.Log("El estado de pasar el juego es" + pasóeljuego);

            menuGanar.SetActive(true);
            menuPausa.SetActive(true);

            cantidadGotas += PlayerPrefs.GetFloat("gotasRecogidas");
            textoganar.text = "x" + cantidadGotas.ToString();

            pasóeljuego = true;
            PlayerPrefs.SetInt("terminóeljuego", (pasóeljuego ? 1 : 0));
        }
    }



}
