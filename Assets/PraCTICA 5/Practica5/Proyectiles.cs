using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectiles : MonoBehaviour
{
    Transform proyectil;
    [SerializeField] List<GameObject> lista_enemigos;
    [SerializeField] Transform ubi_spawn;
    int contador_enemigo_actual;

    private void Awake()
    {
        proyectil = GameObject.Find("Jugador").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("corrutinaTiempo");
    }
    

    void Update()
    {
        lista_enemigos[contador_enemigo_actual].transform.position 
            += Vector3.forward * -1 * 5f * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            lista_enemigos[contador_enemigo_actual].transform.position = ubi_spawn.position;
        }
    }

    IEnumerator corrutinaTiempo()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            contador_enemigo_actual++;
            contador_enemigo_actual %= lista_enemigos.Count;
            
        }
    }

}
        
