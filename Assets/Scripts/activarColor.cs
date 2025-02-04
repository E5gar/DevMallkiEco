using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarColor : MonoBehaviour
{
    public ArcoírisOscuro arcoíriscolor;

    public void ActivarFondo(){
        arcoíriscolor.StartCoroutine(arcoíriscolor.CambiarColorDeFondo());
    }

}
