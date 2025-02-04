using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class baseDeDatosPersonajes : ScriptableObject
{
    public seleccionarPersonaje[] seleccionarpersonaje;
    public int seleccionarPersonajeCount{
        get{
            return seleccionarpersonaje.Length;
        }
    }

    public seleccionarPersonaje GetseleccionarPersonaje(int index){
        return seleccionarpersonaje[index];
    }

}
