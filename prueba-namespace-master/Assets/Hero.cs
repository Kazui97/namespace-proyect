using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.enemy;
using NPC.Ally;

public class Hero : MonoBehaviour
{
    CosasZombie datosZombi;
    CosasCiudadanos datoCiudadanos;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)          // colision de zombi y aldeanos 
    {
        if (collision.transform.name == "Zombi")
        {
            datosZombi = collision.gameObject.GetComponent<ZombieOp>().datosZombi;
            Debug.Log("  waaarrr " + " quiero comer " +  datosZombi.sabroso);
        }


        if (collision.transform.name == "Gente")
        {
            datoCiudadanos = collision.gameObject.GetComponent<CiudadanoOp>().datoCiudadanos;
            Debug.Log("Hola soy " + datoCiudadanos.genteNombres + " y tengo " + datoCiudadanos.edadgente );
        }
    }
}
