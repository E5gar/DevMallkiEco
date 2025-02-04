using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class empiezaBatalla : MonoBehaviour
{

    public GameObject MolinoViento;
    public GameObject TachoBasuraReciclar;
    public GameObject PanelSolar;
    public GameObject Bicicletas;
    public GameObject Hidroelectrica;
    public GameObject Iso14001;

    public GameObject primeraFase;
    public GameObject segundaFase;
    public GameObject terceraFase;
    public GameObject cuartaFase;
    public GameObject quintaFase;
    public GameObject sextaFase;

    public AudioSource audioApareceObjeto;
    public AudioSource audioJefeCurar;
    public AudioSource invocarenemigos;


    saludJefeManager saludjefemanager;
    public timerController timercontroller;

    private void Start() {

        primeraFase.SetActive(false);

        MolinoViento.SetActive(false);
        MolinoViento.transform.localScale = new Vector3(0, 1, 1);

        TachoBasuraReciclar.SetActive(false);
        TachoBasuraReciclar.transform.localScale = new Vector3(0, 1, 1);
        
        PanelSolar.SetActive(false);
        PanelSolar.transform.localScale = new Vector3(0, 1, 1);
        
        Bicicletas.SetActive(false);
        Bicicletas.transform.localScale = new Vector3(0, 1, 1);

        Hidroelectrica.SetActive(false);
        Hidroelectrica.transform.localScale = new Vector3(0, 1, 1);

        Iso14001.SetActive(false);
        Iso14001.transform.localScale = new Vector3(0, 1, 1);

        saludjefemanager = FindObjectOfType<saludJefeManager>();
        timercontroller = FindObjectOfType<timerController>();

    }

    public void EmpiezaLaBatalla(){
        Debug.Log("La batalla comenzó");
        Invoke("EmpiezaElConteo", 5f);

        Invoke("SonidoInvocarEnemigos", 7.7f);
        Invoke("IniciaPrimeraFase", 8f);
        Invoke("ApareceMolino", 11f);

        Invoke("SonidoInvocarEnemigos", 27.7f);
        Invoke("IniciaSegundaFase", 28f);
        Invoke("ApareceTachoBasuraReciclaje", 31f);

        Invoke("SonidoInvocarEnemigos", 47.7f);
        Invoke("IniciaTerceraFase", 48f);
        Invoke("AparecePanelSolar", 51f);

        Invoke("SonidoInvocarEnemigos", 67.7f);
        Invoke("IniciaCuartaFase", 68f);
        Invoke("ApareceBicicletas", 71f);

        Invoke("SonidoInvocarEnemigos", 87.7f);
        Invoke("IniciaQuintaFase", 88f);
        Invoke("CuraUnaVez", 85f);
        Invoke("SonidoCurarse", 87f);
        Invoke("ApareceHidroelectrica", 91f);

        Invoke("SonidoInvocarEnemigos", 107.7f);
        Invoke("IniciaSextaFase", 108f);
        Invoke("ApareceIso14001", 111f);

    }



    private void EmpiezaElConteo(){
        timercontroller.ActivarCuentaAtras();
    }
    private void CuraUnaVez(){
        saludjefemanager.Heal(20);
    }
    private void SonidoCurarse(){
        audioJefeCurar.Play();
    }
    private void SonidoInvocarEnemigos(){
        invocarenemigos.Play();
    }



    private void IniciaPrimeraFase(){
        primeraFase.SetActive(true);
    }

    private void IniciaSegundaFase(){
        segundaFase.SetActive(true);
    }

    private void IniciaTerceraFase(){
        terceraFase.SetActive(true);
    }

    private void IniciaCuartaFase(){
        cuartaFase.SetActive(true);
    }

    private void IniciaQuintaFase(){
        quintaFase.SetActive(true);
    }

    private void IniciaSextaFase(){
        sextaFase.SetActive(true);
    }



    private void ApareceMolino(){       
        MolinoViento.SetActive(true);
        MolinoViento.transform.localScale = new Vector3(0, 1, 1);

        float randomX1 = Random.Range(124.4f, 129.4f);
        float randomY1 = Random.Range(-8.1f, -8.8f);
        MolinoViento.transform.position = new Vector3(randomX1, randomY1, 0);
        
        MolinoViento.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

    private void ApareceTachoBasuraReciclaje(){       
        TachoBasuraReciclar.SetActive(true);
        TachoBasuraReciclar.transform.localScale = new Vector3(0, 1, 1);

        float randomX2 = Random.Range(118.4f, 131.6f);
        float randomY2 = Random.Range(-9.5f, -4.9f);
        TachoBasuraReciclar.transform.position = new Vector3(randomX2, randomY2, 0);
        
        TachoBasuraReciclar.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

        private void AparecePanelSolar(){       
        PanelSolar.SetActive(true);
        PanelSolar.transform.localScale = new Vector3(0, 1, 1);
        float randomX2 = Random.Range(118.4f, 131.6f);
        float randomY2 = Random.Range(-9.5f, -4.9f);
        PanelSolar.transform.position = new Vector3(randomX2, randomY2, 0);
        
        PanelSolar.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

        private void ApareceBicicletas(){       
        Bicicletas.SetActive(true);
        Bicicletas.transform.localScale = new Vector3(0, 1, 1);
        float randomX2 = Random.Range(118.4f, 131.6f);
        float randomY2 = Random.Range(-9.5f, -4.9f);
        Bicicletas.transform.position = new Vector3(randomX2, randomY2, 0);
        
        Bicicletas.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

        private void ApareceHidroelectrica(){       
        Hidroelectrica.SetActive(true);
        Hidroelectrica.transform.localScale = new Vector3(0, 1, 1);
        float randomX2 = Random.Range(118.4f, 131.6f);
        float randomY2 = Random.Range(-9.5f, -4.9f);
        Hidroelectrica.transform.position = new Vector3(randomX2, randomY2, 0);
        
        Hidroelectrica.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

        private void ApareceIso14001(){       
        Iso14001.SetActive(true);
        Iso14001.transform.localScale = new Vector3(0, 1, 1);
        float randomX2 = Random.Range(118.4f, 131.6f);
        float randomY2 = Random.Range(-9.5f, -4.9f);
        Iso14001.transform.position = new Vector3(randomX2, randomY2, 0);
        
        Iso14001.transform.DOScaleX(1, 1f).SetEase(Ease.OutBounce);
        audioApareceObjeto.Play();
    }

}
