using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextUI : MonoBehaviour
{
    Task currentTask;

    public enum StringToShow
    {
        DESCRIPTION,
        HINT //,
        //END
    }

    public StringToShow str;


    void Update()
    {
        currentTask = TaskManager.instance.taskList.Find(task => task.state == Task.TaskProgress.AVAILABLE);
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        
        switch (str)
        {
            case StringToShow.DESCRIPTION:
                textMesh.text = "Étape " + (currentTask.id + 1) + " :\n" + currentTask.description;
                break;

            case StringToShow.HINT:
                textMesh.text = currentTask.hint;
                break;

            /*
            case StringToShow.END:
                textMesh.text = currentTask.finish_sentence;
                break;
            */
        }
        
        
        
    }
}
