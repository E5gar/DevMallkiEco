using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarYOcultarInfo : MonoBehaviour
{
    public GameObject ObjMostrarYOcultar;
    
    public void Mostrar(){
        ObjMostrarYOcultar.SetActive(true);
    }

    public void Ocultar(){
        ObjMostrarYOcultar.SetActive(false);
    }
}
