using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class cambiarEscenas : MonoBehaviour
{
    public float tiempoEspera = 0f;

    public void CargarEscena(string nombreEscena)
    {
        StartCoroutine(CargarEscenaDespuesDeEsperar(nombreEscena, tiempoEspera));
    }

    IEnumerator CargarEscenaDespuesDeEsperar(string nombreEscena, float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene(nombreEscena);
        Time.timeScale = 1f;
    }
}