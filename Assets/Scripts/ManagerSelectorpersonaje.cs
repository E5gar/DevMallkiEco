using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ManagerSelectorpersonaje : MonoBehaviour
{
    public baseDeDatosPersonajes BDpersonaje;
    public TextMeshProUGUI nombreTexto;
    public Image imagenPersonaje;

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

    public void SiguienteOpcion(){
        personajeHaSidoSeleccionado++;
        if(personajeHaSidoSeleccionado >= BDpersonaje.seleccionarPersonajeCount){
            personajeHaSidoSeleccionado = 0;
        }
        UpdatePersonaje(personajeHaSidoSeleccionado);
        Save();
    }

    public void AnteriorOpcion(){
        personajeHaSidoSeleccionado--;
        if(personajeHaSidoSeleccionado<0){
            personajeHaSidoSeleccionado = BDpersonaje.seleccionarPersonajeCount - 1;
        }

        UpdatePersonaje(personajeHaSidoSeleccionado);
        Save();
    }

    private void UpdatePersonaje(int personajeHaSidoSeleccionado){
        seleccionarPersonaje seleccionarpersonaje = BDpersonaje.GetseleccionarPersonaje(personajeHaSidoSeleccionado);
        imagenPersonaje.sprite = seleccionarpersonaje.skindelPersonaje;
        nombreTexto.text = seleccionarpersonaje.nombrePersonaje;
    }

    private void Load()
    {
        personajeHaSidoSeleccionado = PlayerPrefs.GetInt("personajeHaSidoSeleccionado");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("personajeHaSidoSeleccionado", personajeHaSidoSeleccionado);
    }
}
