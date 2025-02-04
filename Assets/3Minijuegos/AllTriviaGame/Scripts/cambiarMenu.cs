using UnityEngine;

public class cambiarMenu : MonoBehaviour
{
    public GameObject MenuAnterior;
    public GameObject MenuActual;
    private ContadorTiempo contadorTiempo;

    private void Start()
    {
        contadorTiempo = FindObjectOfType<ContadorTiempo>();
    }

    public void CambiarMenuAhora()
    {
        if (contadorTiempo != null)
        {
            contadorTiempo.IniciarContador();
        }
        else
        {
            Debug.LogWarning("No se encontró el script ContadorTiempo.");
        }

        MenuAnterior.SetActive(false);
        MenuActual.SetActive(true);
    }
}