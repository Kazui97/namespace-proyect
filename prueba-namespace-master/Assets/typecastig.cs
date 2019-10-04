using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typecastig : MonoBehaviour
{

    class Humanoid
    {

    }
    class zombie : Humanoid
    {

    }
    class person : Humanoid
    {

    }





  
    void Start()
    {
        Humanoid h = new Humanoid();
        zombie z = h as zombie;
        Debug.Log(z);
    }

    void Update()
    {
        
    }
}
