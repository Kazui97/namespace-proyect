using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class castisaga : MonoBehaviour
{
    
    enum simpreenum
    {
        a,
        b,
        c
    }


    void Start()
    {
        simpreenum mysimpleenum = simpreenum.b;
        int myint = (int )mysimpleenum;
        Debug.Log(myint);
    }

    
    void Update()
    {
        
    }
}
