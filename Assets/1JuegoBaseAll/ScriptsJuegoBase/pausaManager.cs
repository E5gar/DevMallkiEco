using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausaManager : MonoBehaviour
{
    public GameObject menuPausa;
    public AudioSource musicaFondo;
    public PlayerRespawn playerrespawn;

    public void PausaBoton()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        musicaFondo.Pause();
    }

    public void Continuar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        musicaFondo.UnPause();
    }

    public void Reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Resetear(){
        Time.timeScale = 1f;
        playerrespawn.ResetCheckpoint();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}