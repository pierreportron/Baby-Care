using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSoap : MonoBehaviour
{
    public GameObject CanvasSoap;
    public static bool haveSoap = false;
    
    void Start()
    {
        CanvasSoap.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            haveSoap = true;
            CanvasSoap.SetActive(true);
        }
    }

    public bool hasSoap()
    {
        return haveSoap;
    }
}
