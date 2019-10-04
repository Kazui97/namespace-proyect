using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    
    class Monster
    {
        public int hitpoints;
        public GameObject gameObject;

        public Monster()
        {
            hitpoints = 10;
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Debug.Log("un nuevo monstruo surge! >:v");
        }
        public virtual int TakeDamage( int damage)
        {
            return hitpoints - damage;
        }
    }

    class Zombie:Monster
    {
        public int brainsEaten = 0;

        public Zombie()
        {
            Debug.Log("zombie constructor");
            gameObject.transform.position = new Vector3(1, 0, 0);
        }
        public override string ToString()
        {
            return string.Format("[Zombie]");
        }

    }
    class vampire : Monster
    {
        public int bloodscked = 0;
        public override int TakeDamage(int damage)
        {
            return hitpoints - (damage / 2);
        }
    }

    

    void Start()
    {
        Zombie z = new Zombie();
        vampire v = new vampire();
        Debug.Log(z.TakeDamage(5));
        Debug.Log(v.TakeDamage(5));

        int number = (int)mState;
        Debug.Log(number);
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10f, -10f);
        pos.z = Random.Range(-10f, - 10f);
        transform.position = pos;
        GameObject[] AllGameObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

        foreach(GameObject aGameObject.GetComponet)






    }

     void OnDrawGizmos()
     {
        Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
    }
    void Update()
    {
       
    }
}
