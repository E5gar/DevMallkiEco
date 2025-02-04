using UnityEngine;
using UnityEngine.UI;

public class Basura : MonoBehaviour
{
    public string tipoBasura;
    private Rigidbody2D rb;
    public GameObject lineaRio;

    public AudioSource Punto, NoPunto;

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0f, Random.Range(4f, 50f));
        rb.drag = 20f;
        InvokeRepeating("ActualizarLinearDrag", 1f, 1f);
    }

    private void ActualizarLinearDrag(){
        rb.drag = rb.drag - 0.1f;
        Debug.Log("Linear drag: " + rb.drag);
    }

    private void OnCollisionEnter2D(Collision2D  collision)
    {
        if (collision.gameObject == lineaRio)
        {
            float randomY = Random.Range(3.9f, 38.9f);
            transform.position = new Vector2(0, randomY);
            Debug.Log("Basura ha tocado el río, se contaminó!");
            puntaje.PerderEstado();
        }
    }

    private void OnMouseDown()
    {
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
    }

    private void OnMouseDrag()
    {
        Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = posicionMouse;
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false;

        Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, transform.localScale, 0);
            
        bool encontrado = false;
        float randomY = Random.Range(3.9f, 38.9f);

        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.tag == "Tacho" && collider.gameObject.name == "Tacho" + tipoBasura)
            {
                Debug.Log("Punto!");

                transform.position = new Vector2(0, randomY);
                puntaje.SumarPuntos(cantidadPuntos);
                encontrado = true;
                Punto.Play();

                break;
            }
        }

        if (!encontrado)
        {
            Debug.Log("Basura no clasificada o dejada!");
            puntaje.PerderEstado();
            NoPunto.Play();

            transform.position = new Vector2(0, randomY);
        }
    }
    }