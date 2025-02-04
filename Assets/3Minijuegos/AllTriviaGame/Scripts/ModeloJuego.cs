using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Trivia/Crear Modelo Juego")]

public class ModeloJuego : ScriptableObject
{
    public List<ModeloCategorías> Categorías;
}
