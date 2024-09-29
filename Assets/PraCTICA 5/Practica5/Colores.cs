using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour
{
    [SerializeField] Material nuevoMaterial;  // El nuevo material que se asignará
    Renderer jugadorRenderer; // Referencia al Renderer del jugador

    private void Awake()
    {
        GameObject jugador = GameObject.Find("Jugador");

        jugadorRenderer = jugador.GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (jugadorRenderer != null)
        {
            jugadorRenderer.material = nuevoMaterial;
        }
    }
}
