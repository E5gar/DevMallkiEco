using UnityEngine;

public class AudioClasificar : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void PauseSound()
    {
        audioSource.Pause();
    }

    public void ContinueSound()
    {
        audioSource.UnPause();
    }
}
