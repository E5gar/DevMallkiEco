using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverFondo : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadDeFondo;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D personaje;

    private void Awake() {
        material = GetComponent<SpriteRenderer>().material;
        personaje = GameObject.FindGameObjectWithTag("personaje").GetComponent<Rigidbody2D>();
    }

    private void Update() {
        offset = (personaje.velocity.x * 0.1f) * velocidadDeFondo * Time.deltaTime;
        material.mainTextureOffset += offset;
    }

}
