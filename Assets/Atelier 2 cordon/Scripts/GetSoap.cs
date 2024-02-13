using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSoap : MonoBehaviour
{
    bool haveSoap = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            haveSoap = true;
        }
    }

    public bool hasSoap()
    {
        return haveSoap;
    }
}
