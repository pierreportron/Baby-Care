using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingHands : MonoBehaviour
{
    
    public int taskID = 0;
    public GameObject waterTap;
    public GameObject soap;

    void OnTriggerEnter(Collider other)
    {
        if(TaskManager.instance.isAvailable(taskID)) //do it only if the task is available
        {
            if (other.CompareTag("PlayerHand"))
            {
                if (waterTap.GetComponent<WaterTap>().GetOpenState() && soap.GetComponent<GetSoap>().hasSoap()) //verify if the tap is opened and if the player has soap
                {
                    //task completed
                    TaskManager.instance.UpdateTaskState(taskID);
                }
                else
                {
                    //UI text
                    Debug.Log("Ouvrez le robinet et prenez du savon.");
                }
            }
        }
        
    }
}
