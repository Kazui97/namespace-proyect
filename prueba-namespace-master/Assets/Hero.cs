using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.enemy;
using NPC.Ally;

public class Hero : MonoBehaviour
{
    CosasZombie datosZombi; // variables de los estructura de los zombies
    CosasCiudadanos datoCiudadanos; // variables de la structura de los ciudadnos 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)          // colision de zombi y aldeanos 
    {
        if (collision.transform.name == "Zombi") // al colicionar con los zombie apareceraun mensaje en la consola que tiene el gusto del zombi
        {
            datosZombi = collision.gameObject.GetComponent<ZombieOp>().datosZombi;
            Debug.Log("  waaarrr " + " quiero comer " +  datosZombi.sabroso);
        }


        if (collision.transform.name == "Gente")    // al colicionar con u aldeano este crea un mensaje que aparece en la consola con unos datos
        {
            datoCiudadanos = collision.gameObject.GetComponent<CiudadanoOp>().datoCiudadanos;
            Debug.Log("Hola soy " + datoCiudadanos.genteNombres + " y tengo " + datoCiudadanos.edadgente );
        }
    }
}
