using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class ActivarJefe : MonoBehaviour
{
    public Camera gameCamera;
    public Camera gameCameraBoss;
    public GameObject objetoADesactivar;
    public GameObject objetoConSeguimiento;
    invocarJefe invocarjefe;
    public GameObject barraJefe;
    empiezaBatalla empiezabatalla;

    public ControlAudio controlAudio;

    private seguimientoenX seguimientoenXScript;

    void Start() {
        gameCamera.enabled = true;
        gameCameraBoss.enabled = false;
        objetoADesactivar.SetActive(false);
        invocarjefe = FindObjectOfType<invocarJefe>();
        empiezabatalla = FindObjectOfType<empiezaBatalla>();
        barraJefe.SetActive(false);
        barraJefe.transform.localScale = new Vector3(0, 1, 1);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("personaje")) {
            Debug.Log("entrando a la pelea");
            gameCamera.enabled = false;
            gameCameraBoss.enabled = true;
            objetoADesactivar.SetActive(true);
            invocarjefe.subirJefe();
            barraJefe.SetActive(true);
            barraJefe.transform.DOScaleX(1, 4.5f).SetEase(Ease.OutBounce);

            empiezabatalla.EmpiezaLaBatalla();
            seguimientoenXScript = objetoConSeguimiento.GetComponent<seguimientoenX>();

            controlAudio.BajarVolumen();


            if (seguimientoenXScript != null) {
                seguimientoenXScript.seguir = false;
                Vector3 newPos = seguimientoenXScript.transform.position;
                newPos.x = 125.5f;
                seguimientoenXScript.transform.position = newPos;
            }
        }

        Destroy(gameObject);
            
    }




}