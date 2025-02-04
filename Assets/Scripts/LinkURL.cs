using UnityEngine;

public class LinkURL : MonoBehaviour
{
    public string URLinput;

    public void AbrirURL()
    {
        Application.OpenURL(URLinput);
    }
}