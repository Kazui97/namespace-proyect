using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NPC.enemy;
using NPC.Ally;
using System;



public class Generador : MonoBehaviour
{
    GameObject ZombieMesh;      //cracion de gameobject de zombie
    GameObject Gente;           //cracion de gameobject de los ciudadanos
    GameObject Hero;            //cracion de gameobject del hero 
    CosasZombie datoZombi;      // variable de la estructura de los zombies
    CosasCiudadanos datoCiudadanos; //variable de la estructura de los ciudadnos
    readonly int minimo;            
    const int maximo = 25;          // creaciond de una variable contaten que siempre mantiene su valor
    int cantbody;                   // creacion de variable para guardar el resutado de un rando,
    public Text enemy;              // creacionde variables para la creacion de una texto en canvas
    public Text Text;              // creacionde variables para la creacion de una texto en canvas



    System.Random rn = new System.Random();     // rando de lalibrerias system 

    public Generador()
    {
        minimo = rn.Next(5, 15);    //rango de creación

    }

    void Start()
    {                                 // generador de NPC
        cantbody = rn.Next(minimo, maximo);
        for (int i = 0; i < cantbody; i++)
        {
            if (rn.Next(0, 2) == 0)
            {                               // generador de zombis
                ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);    // creacion de un primityve para los zombies
                ZombieMesh.AddComponent<ZombieOp>();

                datoZombi = ZombieMesh.GetComponent<ZombieOp>().datosZombi;
                switch (datoZombi.colorEs)                                      // cambio de color para los zombie cuando se crean 
                {
                    case CosasZombie.ColorZombie.magenta:
                        ZombieMesh.GetComponent<Renderer>().material.color = Color.magenta;

                        break;
                    case CosasZombie.ColorZombie.green:
                        ZombieMesh.GetComponent<Renderer>().material.color = Color.green;

                        break;
                    case CosasZombie.ColorZombie.cyan:
                        ZombieMesh.GetComponent<Renderer>().material.color = Color.cyan;
                        break;
                }


                Vector3 pos = new Vector3(rn.Next(-10, 10), 0, rn.Next(-10, 10));       // posicion de la creacion de los zombie
                ZombieMesh.transform.position = pos;
                ZombieMesh.AddComponent<Rigidbody>();
                ZombieMesh.name = "Zombi";
            }
            else // generador de ciudadanos
            {
                Gente = GameObject.CreatePrimitive(PrimitiveType.Cube); // creacion de un primitive para el ciudadano
                Gente.AddComponent<CiudadanoOp>();
                Vector3 po = new Vector3(rn.Next(-20, 10), 0, rn.Next(10, 10)); //posisicon de la creacion de los aldeanos 
                Gente.transform.position = po;
                Gente.AddComponent<Rigidbody>();
                Gente.name = "Gente";
            }
        }

        // generador hero 
        Hero = GameObject.CreatePrimitive(PrimitiveType.Cube);  // creacionde de un primitive para el hero
        Hero.AddComponent<MovimientoTeclado>();
        Hero.AddComponent<Hero>();
        Hero.AddComponent<Camera>();
        Hero.AddComponent<Rigidbody>();
        Hero.name = "Hero";


        int numzombie = 0;
        int numaldeanos = 0;


        foreach (ZombieOp enemy in Transform.FindObjectsOfType<ZombieOp>())         // este busca a todos los objeto que tenga el scrit de zombies y los coloca en un enumerado para despues llamaros a canvas
        {
            numzombie++;
        }

        foreach (CiudadanoOp ally in Transform.FindObjectsOfType<CiudadanoOp>())// este busca a todos los objeto que tenga el scrit de ciudadanos y los coloca en un enumerado para despues llamaros a canvas
        {
            {
                numaldeanos++;
            }
            Debug.Log(numzombie);
            enemy.text = "zombies: " + numzombie;
            Text.text = "aldeanos: " + numaldeanos;
        }




    }
}
