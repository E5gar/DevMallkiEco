using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinSeleccionadoParaElPersonaje : MonoBehaviour
{
    public baseDeDatosPersonajes BDpersonaje;
    public SpriteRenderer imagenPersonaje;

    private int personajeHaSidoSeleccionado = 0;

    
    void Start()
    {
        if(!PlayerPrefs.HasKey("personajeHaSidoSeleccionado")){
            personajeHaSidoSeleccionado = 0;
        }

        else{
            Load();
        }

        UpdatePersonaje(personajeHaSidoSeleccionado);
    }


    private void UpdatePersonaje(int personajeHaSidoSeleccionado){
        seleccionarPersonaje seleccionarpersonaje = BDpersonaje.GetseleccionarPersonaje(personajeHaSidoSeleccionado);
        imagenPersonaje.sprite = seleccionarpersonaje.skindelPersonaje;
    }

    private void Load()
    {
        personajeHaSidoSeleccionado = PlayerPrefs.GetInt("personajeHaSidoSeleccionado");
    }

}