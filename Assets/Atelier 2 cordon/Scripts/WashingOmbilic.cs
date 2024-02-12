using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingOmbilic : MonoBehaviour
{

    public GameObject ZoneNettoyage;
    public GameObject Water;
    public int taskID = 1;

    bool isCompleted = false;

    void Update()
    {
        if (ZoneNettoyage.GetComponent<DetectionCollider>().isCollided() && Water.GetComponent<DetectionCollider>().isCollided() && !isCompleted)
        {
            //task completed
            TaskManager.instance.UpdateTaskState(taskID);

            isCompleted = true;
        }

    }

}
