using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de incluir este namespace si usas TextMeshPro

public class MensajeInicial : MonoBehaviour
{
    public string mensaje = "Encuentra al elfo Dobby y haz click derecho al estar cerca a él";
    public float duracionMensaje = 5f; // Duración en segundos
    private GameObject dialoguePanel; // Referencia al panel de diálogo

    void Start()
    {
        // Encuentra el componente TextMeshProUGUI en los hijos del GameObject
        TextMeshProUGUI texto = transform.Find("DialoguePanel/DialogueText").GetComponent<TextMeshProUGUI>();
        // Encuentra el panel de diálogo
        dialoguePanel = transform.Find("DialoguePanel").gameObject;

        if (texto != null && dialoguePanel != null)
        {
            texto.text = mensaje;
            Invoke("OcultarMensaje", duracionMensaje);
        }
        else
        {
            Debug.LogError("No se encontró el componente TextMeshProUGUI o el panel de diálogo.");
        }
    }

    void OcultarMensaje()
    {
        // Desactiva el panel de diálogo para ocultar el mensaje
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
    }
}
