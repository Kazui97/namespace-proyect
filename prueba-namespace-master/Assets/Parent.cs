using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class Parent : MonoBehaviour
{
    
    void Start()
    {
        ParentFuncion();
       
    }
    public void ParentFuncion()
    {
        print("MADRE");

    }
    public void FunctionA()
    {
        print("la funcion A");
    }
   public void functionB()
    {
        print("la funcion B");
    }
    void Update()
    {
        
    }
}
