using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CambiarEscena", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CambiarEscena()
    {
        // Cambia a la escena llamada "SampleScene".
        SceneManager.LoadScene("MenuScene");
    }
}
