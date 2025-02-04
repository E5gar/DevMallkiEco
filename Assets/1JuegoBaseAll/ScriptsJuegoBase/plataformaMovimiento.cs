using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovimiento : MonoBehaviour
{
    public GameObject MoverAlObjeto;
    public Transform PuntoInicio;
    public Transform PuntoFinal;

    public float VelocidadAMover;
    private Vector3 MoverHacia;
    
    void Start()
    {
     MoverHacia = PuntoFinal.position;
    }

    void Update()
    {
        float t = Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time * VelocidadAMover, 1f));
        MoverAlObjeto.transform.position = Vector3.Lerp(PuntoInicio.position, PuntoFinal.position, t);

            if(MoverAlObjeto.transform.position == PuntoFinal.position){
        MoverHacia = PuntoInicio.position;
    }

            if(MoverAlObjeto.transform.position == PuntoInicio.position){
                MoverHacia = PuntoFinal.position;
            }

    }
}
