using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Sonido : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlayerInside = false; //sirve para rastrear si el jugador esta dentro del trigger o no
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInside && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            isPlayerInside = true;
            audioSource.Play();
            
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
            isPlayerInside = false;
            audioSource.Stop();
        }
    }
}