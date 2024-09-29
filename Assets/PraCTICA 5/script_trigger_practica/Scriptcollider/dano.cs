using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano : MonoBehaviour
{
    [SerializeField] private float tiempoentreDano;

    private float tiemposiguienteDano;
    private void OnTriggerStay(Collider other){
        if(other.CompareTag("Player"))
        {
            tiemposiguienteDano -= Time.deltaTime;
            if (tiemposiguienteDano <= 0){
                other.GetComponent<vidajugador>().TomarDano(30);
                tiemposiguienteDano = tiempoentreDano;
                }
            }
    }
}
