using UnityEngine;

public class sumarGotas : MonoBehaviour
{
    public GameObject ObjGotas;
    public float cantidadGotasQueDa;
    public AudioSource audioGanarGotas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("personaje"))
        {
            ObjGotas.GetComponent<RecogerGotasPuntos>().cantidadGotas += cantidadGotasQueDa;

            if (audioGanarGotas != null)
            {
                audioGanarGotas.Play();
            }
            PlayerPrefs.SetInt(gameObject.name, 1);
            Destroy(gameObject);
        }
    }


    private void Start(){
    if (PlayerPrefs.GetInt(gameObject.name, 0) == 1)
    {
        Destroy(gameObject);
    }
}
}