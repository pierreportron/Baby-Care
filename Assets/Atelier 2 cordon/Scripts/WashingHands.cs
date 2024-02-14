using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingHands : MonoBehaviour
{

    public GameObject CanvasEnd;

    public int taskID = 0;
    public GameObject waterTap;
    public GameObject soap;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            if (waterTap.GetComponent<WaterTap>().GetOpenState() && soap.GetComponent<GetSoap>().hasSoap()) //verify if the tap is opened and if the player has soap
            { 
                //task completed
                TaskManager.instance.UpdateTaskState(taskID);

                CanvasEnd.SetActive(true);
            }

        }

        
    }
}
