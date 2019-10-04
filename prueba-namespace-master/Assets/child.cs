using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child : Parent
{
    
    void Start()
    {
        ParentFuncion();
        base.FunctionA();
    }
    public virtual void FunctionAA()
    {
        print("la Nueva funcion AA");
    }

    void Update()
    {
        
    }
}
