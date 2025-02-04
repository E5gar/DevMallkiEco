using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource sonidoAlEntrarJefe;

    public void BajarVolumen()
    {
        audioSource.volume = 0f;
        Invoke("RestaurarVolumen", 5f);
        sonidoAlEntrarJefe.Play();

    }

    private void RestaurarVolumen()
    {
        audioSource.volume = 0.084f;
        audioSource.pitch = -0.6f;
    }

    public void VolumenNormal(){
        Invoke("VolumenNormal22", 2f);
    }

    private void VolumenNormal22(){
        audioSource.volume = 0.034f;
        audioSource.pitch = 0.9f;
    }
}