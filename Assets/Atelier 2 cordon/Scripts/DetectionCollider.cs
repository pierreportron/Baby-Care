using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCollider : MonoBehaviour
{
    private bool iscollided = false;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coton"))
        {
            iscollided = true;
            print("coton");
        }
    }


    public bool isCollided()
    {
        return iscollided;
    }


    /*
   void OnTriggerExit(Collider other)
   {
       if (other.CompareTag("Coton"))
       {
           iscollided = false;
       }
   }*/
}
