using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldingDiaper : MonoBehaviour
{
    public GameObject diaperFolded;
    public int taskID = 3;

    void Update()
    {
        if (diaperFolded.activeSelf) //if diaper folded is active (so visible)
        {
            //task completed
            print("task 4 completed");
            TaskManager.instance.UpdateTaskState(taskID);
        }
    }
    
}
