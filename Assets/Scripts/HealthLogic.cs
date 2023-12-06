using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLogic : MonoBehaviour
{
    public int initialLives = 3;
    private int currentLives;

    void Start()
    {
        currentLives = initialLives;
    }

    void Update(){
        Debug.Log("Vidas: "+currentLives);
    }

    // Método para restar una vida
    void LoseLife()
    {
        currentLives--;

        // Aquí puedes agregar lógica adicional cuando se pierde una vida, como reproducir un sonido, mostrar un efecto, etc.

        // Verificar si se quedó sin vidas
        if (currentLives <= 0)
        {
            // Aquí puedes agregar lógica cuando el jugador se queda sin vidas, como reiniciar el nivel o mostrar un mensaje de fin de juego.
        }
    }

    // Método para sumar una vida
    void GainLife()
    {
        if (currentLives < 3)
        {
            currentLives++;

            // Aquí puedes agregar lógica adicional cuando se gana una vida.
        }
    }

    // Método para manejar las colisiones
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Objeto colisionado: " + other.name + ", Tag: " + other.tag);
        // Verificar si colisiona con un obstáculo
        if (other.CompareTag("Obstacles"))
        {
            // Restar una vida
            LoseLife();
        }
        // Verificar si colisiona con una galleta
        else if (other.CompareTag("Cookie"))
        {
            // Sumar una vida
            GainLife();

            // Puedes desactivar o destruir el objeto de la galleta si prefieres
            Destroy(other.gameObject);
        }
    }
}
