using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curacion : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
     if(other.gameObject.CompareTag("Player")){
        other.gameObject.GetComponent<vidajugador>().Curar(10);
      //Destroy(gameObject);
     }
    }
}
