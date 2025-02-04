using UnityEngine;
using TMPro;

public class ContadorTiempo : MonoBehaviour
{
    public TMP_Text textoTiempo;
    public float tiempoTranscurrido = 0f;
    private bool contadorActivo = false;

    public int minutos = 0;
    public int segundos = 0;

    private void Start()
    {
        ActualizarTextoTiempo(0f);
    }

    private void Update()
    {
        if (contadorActivo)
        {
            tiempoTranscurrido += Time.deltaTime;
            ActualizarTextoTiempo(tiempoTranscurrido);
        }
    }

    public void IniciarContador()
    {
        tiempoTranscurrido = 0f;
        contadorActivo = true;
        Debug.Log("Empieza Cuenta");
    }

    public void PausarContador()
    {
        contadorActivo = false;
    }

    public void FinalizarContador()
    {
        contadorActivo = false;
    }

    private void ActualizarTextoTiempo(float tiempo)
    {
        minutos = Mathf.FloorToInt(tiempo / 60f);
        segundos = Mathf.FloorToInt(tiempo % 60f);
        string texto = "Tiempo " + minutos.ToString("00") + ":" + segundos.ToString("00");
        textoTiempo.text = texto;
    }
}
