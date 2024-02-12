using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingHands : MonoBehaviour
{
    public static bool haveSoap;
    public int taskID = 0;
    public GameObject waterTap;

    
    void Start()
    {
        haveSoap = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            if (waterTap.GetComponent<WaterTap>().GetOpenState() && haveSoap) //verify if the tap is opened and if the player has soap
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
