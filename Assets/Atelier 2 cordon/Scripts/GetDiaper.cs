using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDiaper : MonoBehaviour
{
    public GameObject diaperPrefab;

    private GameObject instantiatedDiaper;

    void OnTriggerEnter(Collider other)
    {
        if (TaskManager.instance.isAvailable(3)) //if task 3 is available
        {
            if (other.CompareTag("PlayerHand"))
            {
                instantiatedDiaper = Instantiate(diaperPrefab, other.gameObject.transform.position, Quaternion.identity);
                instantiatedDiaper.tag = "Diaper";
                instantiatedDiaper.transform.parent = other.gameObject.transform;
            }
        }
        
    }
}
