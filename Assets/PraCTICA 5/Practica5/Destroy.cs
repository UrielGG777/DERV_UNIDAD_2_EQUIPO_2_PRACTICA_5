using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    

    void Start()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("TypeEnemy"))
        {
            Destroy(gameObject);
        
        }
    }
}
