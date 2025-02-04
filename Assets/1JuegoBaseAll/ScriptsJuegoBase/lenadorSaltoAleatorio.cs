using UnityEngine;

public class lenadorSaltoAleatorio : MonoBehaviour
{
    public float minTime = 1f;
    public float maxTime = 2f;
    public float FuerzaSalto = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("SaltarSinFinAleatoriamente", Random.Range(minTime, maxTime));
    }

    void SaltarSinFinAleatoriamente()
    {
        rb.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
        Invoke("SaltarSinFinAleatoriamente", Random.Range(minTime, maxTime));
    }
}