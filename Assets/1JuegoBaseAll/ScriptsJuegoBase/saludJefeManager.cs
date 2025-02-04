using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saludJefeManager : MonoBehaviour
{

    public PasasteElJuego pasasteeljuego;


    private void Start() {
        pasasteeljuego = FindObjectOfType<PasasteElJuego>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Return)){
            JefeTomaDaño(20);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Heal(20);
        }

        if(montoSalud <=0){
            pasasteeljuego.PasasteElJuegoA();
        }
    }

    public Image barraSalud;
    public float montoSalud = 100f;

    public void JefeTomaDaño(float dañoJefe){
        montoSalud -= dañoJefe;
        barraSalud.fillAmount = montoSalud / 100f;
    }

    public void Heal(float montoCurar){
        montoSalud += montoCurar;
        montoSalud = Mathf.Clamp(montoSalud, 0, 100);

        barraSalud.fillAmount = montoSalud / 100f;

    }

}
