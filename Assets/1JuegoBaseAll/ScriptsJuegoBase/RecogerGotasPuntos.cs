using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecogerGotasPuntos : MonoBehaviour
{
    public float cantidadGotas;
    public TextMeshProUGUI textoGotas;

    private void Start() {
        cantidadGotas += PlayerPrefs.GetFloat("gotasRecogidas");
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("gotasRecogidas", cantidadGotas);
        textoGotas.text = "x" + cantidadGotas.ToString();
    }
}