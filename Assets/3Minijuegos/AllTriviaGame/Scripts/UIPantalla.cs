using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class UIPantalla : MonoBehaviour
{
    public List<string> Categorías;
    public int CantidadVueltas;
    public float DuraciónVuelta;
    public Transform BotonJugar;

    public Transform Ruleta;
    public Button BotonGirarRuleta;
    public TextMeshProUGUI MostrarTextoCategoría;
 
    private void Start() {
    BotonGirarRuleta.interactable = true;   
    }

    public void GirarRuleta(){
        float randomAngulo = Random.Range(0,360);
        float rotarAngulos = (360 * CantidadVueltas) + randomAngulo;

        Ruleta.DOLocalRotate(new Vector3(0,0,rotarAngulos*-1), DuraciónVuelta, RotateMode.FastBeyond360).onComplete += AlTerminardeGirar;
        BotonGirarRuleta.interactable = false;

        GameManager.Instance.EstablecerCategoria(CategoríaSeleccionada(randomAngulo));
        Debug.Log(CategoríaSeleccionada(randomAngulo));
        MostrarTextoCategoría.text = "Categoría: " + CategoríaSeleccionada(randomAngulo);
    }

    private void AlTerminardeGirar(){
        BotonJugar.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
    }

    public string CategoríaSeleccionada(float angulo){
        var angulosPorCategoria = 360 / Categorías.Count;
        return Categorías[(int)(angulo/angulosPorCategoria)];
    }

    

}
