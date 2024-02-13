using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaperSpawn : MonoBehaviour
{
    public GameObject wellPlacedDiaper;

    void Start()
    {
        wellPlacedDiaper.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Diaper"))
        {
            Destroy(other.gameObject);
            wellPlacedDiaper.SetActive(true);
        }
    }

}
