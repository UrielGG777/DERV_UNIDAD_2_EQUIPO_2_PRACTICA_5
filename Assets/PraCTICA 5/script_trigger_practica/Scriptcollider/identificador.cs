using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class identificador : MonoBehaviour
{

    private float tiempo;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other){
        if(other.collider.CompareTag("Player")){
            Debug.Log("Tocando el cubo :D");
        }
    }
    private void OnCollisionStay(Collision other){
        if(other.collider.CompareTag("Player")){
            tiempo += Time.deltaTime;
            Debug.Log("Tocando el cubo en");
        }
    }
    private void OnCollisionExit(Collision other){
        if(other.collider.CompareTag("Player")){
            Debug.Log("Te fuiste :( :" + tiempo);
            tiempo = 0;
        }
    }
}
