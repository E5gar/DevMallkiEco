using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cambiarTextoAleatoriamente : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public List<string> messages = new List<string>();

    void Start()
    {
        ChangeRandomMessage();
    }

    void ChangeRandomMessage()
    {
        if (messages.Count > 0)
        {
            int randomIndex = Random.Range(0, messages.Count);
            string randomMessage = messages[randomIndex];
            textMeshPro.text = randomMessage;
        }
        else
        {
            Debug.LogWarning("La lista de mensajes está vacía.");
        }
    }
}