using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactWater : MonoBehaviour
{
    public Material waterMat;
    bool isWet = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            isWet = true;
            print("is wet");

            //change material
            this.GetComponent<MeshRenderer>().material = waterMat;
        }
    }

    public bool isItWet()
    {
        return isWet;
    }

}
