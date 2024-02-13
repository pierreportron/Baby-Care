using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDiaper : MonoBehaviour
{
    public GameObject diaperUnfolded;
    public GameObject diaperFolded;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            diaperUnfolded.SetActive(false);
            diaperFolded.SetActive(true);
        }
    }
}
