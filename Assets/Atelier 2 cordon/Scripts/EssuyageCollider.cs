using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssuyageCollider : MonoBehaviour
{
    private bool iscollided = false;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coton"))
        {
            if (!other.GetComponent<ContactWater>().isItWet()) //if it's dry
            {
                iscollided = true;
                print("coton");
            }
            
        }
    }


    public bool isCollided()
    {
        return iscollided;
    }


}
