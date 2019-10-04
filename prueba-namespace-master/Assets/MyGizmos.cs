using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyGizmos : MonoBehaviour
{
    GameObject pru;

     void OnDrawGizmos()
     {
        Ray r = new Ray();
        r.origin = new Vector3(0, 0, 0);
        r.direction = new Vector3(0, 1, 0);
        Gizmos.DrawRay (r);
        //Gizmos.DrawRay (new Ray (new Vector3(0, 0, 0), new Vector3(0, 1, 0)));
        Gizmos.DrawLine(transform.position, new Vector3(0,0,0));
     }


    void Start()
    {
        int i = Random.Range(1, 5);
        for (int a = 0; a < i; a++)
        {
            pru = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //pru.AddComponent<MyGizmos>();
            Vector3 Pos = new Vector3(Random.Range(-5, 10), 0, Random.Range(5, 10));
            pru.transform.position = Pos;
        }
           
        
        
    }

    
    void Update()
    {
        
    }
}
