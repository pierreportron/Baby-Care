using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryingOmbilic : MonoBehaviour
{

    public GameObject ZoneEssuyage;
    public int taskID = 2;

    bool isCompleted = false;

    void Update()
    {
        if (ZoneEssuyage.GetComponent<EssuyageCollider>().isCollided() && !isCompleted)
        {
            //task completed
            print("task 3 completed");
            TaskManager.instance.UpdateTaskState(taskID);

            ZoneEssuyage.SetActive(false);
            isCompleted = true;
        }

    }

}
