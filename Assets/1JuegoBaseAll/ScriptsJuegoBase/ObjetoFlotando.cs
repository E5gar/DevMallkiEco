using UnityEngine;

public class ObjetoFlotando : MonoBehaviour
{
    public float amplitud = 0.07f; 
    public float velocidadMinima = 2.5f; 
    public float velocidadMaxima = 3.0f; 

    private Vector3 posicionInicial;
    private float velocidad;

    void Start()
    {
        posicionInicial = transform.position;
        velocidad = Random.Range(velocidadMinima, velocidadMaxima);
    }

    void Update()
    {
        transform.position = posicionInicial + new Vector3(0, Mathf.Sin(Time.time * velocidad) * amplitud, 0);
    }
}