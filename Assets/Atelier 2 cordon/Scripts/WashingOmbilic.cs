using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingOmbilic : MonoBehaviour
{

    public GameObject ZoneNettoyage;
    public GameObject ZoneEssuyage;
    public GameObject Water;
    public int taskID = 1;

    bool isCompleted = false;

    void Start()
    {
        ZoneNettoyage.SetActive(true);
        ZoneEssuyage.SetActive(false);
    }

    void Update()
    {
        if (TaskManager.instance.isAvailable(taskID)) //do it only if the task is available
        {
            if (ZoneNettoyage.GetComponent<NettoyageCollider>().isCollided() && !isCompleted)
            {
                //task completed
                print("task 2 completed");
                TaskManager.instance.UpdateTaskState(taskID);

                ZoneNettoyage.SetActive(false);
                ZoneEssuyage.SetActive(true);
                isCompleted = true;
            }
        }
        
    }

}
