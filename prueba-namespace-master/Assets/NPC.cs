using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NPC               // creacion de los namespace
{
    namespace enemy
    {
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        public class ZombieOp : MonoBehaviour
        {      
            public CosasZombie datosZombi;          // variable de la estructura delos zombies
            int cambimov; // variable para el cambio de movimiento
            void Awake()
            {
                datosZombi.colorEs = (CosasZombie.ColorZombie)Random.Range(0, 3); // random para los colores de los zombies
                int dargusto = Random.Range(0, 5);  //random para el gusto
                datosZombi.sabroso = (CosasZombie.Gustos)dargusto; //asignacion del random de los zombie
            }
            void Start()
            {
                
             datosZombi.condicion = (CosasZombie.Estados)0;     // inicio de la corutina
             StartCoroutine ("Cambioestado");   //iniciando lacorutina
            }


            void Update()       //cambio de los estado de los zombies
            {       
                switch(datosZombi.condicion)
                {
                case CosasZombie.Estados.Idle:
                transform.position += new Vector3(0, 0f, 0);
                break;
                case CosasZombie.Estados.Moving:
                if (cambimov == 0)
                {
                transform.position += new Vector3(0, 0, 0.03f);
                }
                else if (cambimov == 1)
                {
                transform.position -= new Vector3(0, 0, 0.03f);
                }
                else if(cambimov == 2)
                {
                transform.position -= new Vector3(0.03f, 0, 0);
                }
                else if (cambimov == 3)
                {
                transform.position += new Vector3(0.03f, 0, 0);
                }
                break; 

                case CosasZombie.Estados.Rotating:
                transform.eulerAngles += new Vector3 (0,0.5f,0);
                
                break;

                default:
                break;
                }
            }
            IEnumerator Cambioestado()  // la corutina cambiara el estado del zombi cada 3 sg
            {
                while (true)
                {
                    datosZombi.condicion = (CosasZombie.Estados)Random.Range(0, 3);                   
                    yield return new WaitForSeconds(3);

                    if (datosZombi.condicion == (CosasZombie.Estados)0)
                    {
                        datosZombi.condicion = (CosasZombie.Estados)1;
                        cambimov = Random.Range(0, 3);
                    }
                    else if (datosZombi.condicion == (CosasZombie.Estados)1)
                    {
                        datosZombi.condicion = (CosasZombie.Estados)2;
                    }
                    
                }   
                    //while (true)
                    //{
                    //    if (datosZombi.condicion == (CosasZombie.Estados)0)
                    //{
                    //    datosZombi.condicion = (CosasZombie.Estados)1;
                    //    cambimov = Random.Range(0, 3);
                    //}
                    //else
                    //{
                    //    datosZombi.condicion = (CosasZombie.Estados)0;

                    //}
                    //    yield return new WaitForSeconds(3);
                    //}
            }
        }

        public struct CosasZombie       // estructura que contiene los enum de los zombies
        {
            public enum Gustos 
            {
                Brazos,
                Piernas,
                Huesitos,
                Ojito,
                corazoncito
            };
            public Gustos sabroso;

            public enum Estados
            {
                Idle,
                Moving,
                Rotating
            };
            public Estados condicion;

            public enum ColorZombie
            {
                magenta,
                green, 
                cyan
            };
            public ColorZombie colorEs;
        }

    }

    namespace Ally      // el namespace de los aldeanos
    {
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        public class CiudadanoOp : MonoBehaviour
        {
            public CosasCiudadanos datoCiudadanos;  //variable de la estructura de los ciudadnos

            void Awake()
            {


                int darnombre = Random.Range(0, 20);    ////random de los nombres de los ciudadanos
                datoCiudadanos.genteNombres = (CosasCiudadanos.Nombres)darnombre;   ///variable que guarda el random de los nombre
                int daredad = Random.Range(15, 100);//random de las edades
                datoCiudadanos.edadgente = (CosasCiudadanos.Edad)daredad;//variables que guarda el random de las edades

            }

    
            void Update()
            {
        
            }
        }

        public struct CosasCiudadanos           //estructura de los aldeanos que guarda los enum
        {
            public enum Nombres
            {
                stubbs,
                rob,
                toreto,
                pequeñotim,
                doncarlos,
                carlosII,
                carlosI,
                sergio,
                stevan,
                tutiaentanga,
                panzerottedelsena,
                cj,
                haytevoysampedro,
                sanpeludo,
                alexisdelpeludoII,
                putoalexis,
                jason,
                andrey,
                atreus,
                artion,
                kratos,
                zeus,
                loki,
                sam,
                wilson,
                elbrayan,
                venites,
                sampedro,
            }
            public Nombres genteNombres;

            public enum Edad
            {
                edad
            }
            public Edad edadgente;
        }

    }

}


//public class speed
//{    
//    public readonly int maxvel = 1;
    
//    public speed ( int vel)
//    {
//        this.maxvel = vel;
//    }                
//}