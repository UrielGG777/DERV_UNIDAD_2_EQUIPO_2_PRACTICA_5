using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidajugador : MonoBehaviour
{
    [SerializeField] int vida;

    [SerializeField] int maximovida;
    // Start is called before the first frame update
    void Start()
    {
        vida = maximovida;
    }

    public void TomarDano(int dano){
        vida -= dano;
        if(vida <= 0)
        {
         Destroy(gameObject);
        }
     }

     public void Curar(int curacion)
     {
        if((vida + curacion) > maximovida)
        {
        vida = maximovida;
     }
     else
     {
        vida += curacion;

     }
     }
}
    
