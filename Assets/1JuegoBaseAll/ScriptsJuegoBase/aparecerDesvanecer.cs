using UnityEngine;
using DG.Tweening;

public class aparecerDesvanecer : MonoBehaviour
{
    public GameObject myGameObject;
    
    void Start()
    {
        Color initialColor = myGameObject.GetComponent<SpriteRenderer>().color;
        initialColor.a = 0;
        myGameObject.GetComponent<SpriteRenderer>().color = initialColor;
        myGameObject.SetActive(false);
    }

    public void aparecerOrquidea()
    {
        myGameObject.SetActive(true);
        Invoke("mostrar",3f);
    }

    private void mostrar(){
        myGameObject.GetComponent<SpriteRenderer>().DOFade(1, 1);
    }
}