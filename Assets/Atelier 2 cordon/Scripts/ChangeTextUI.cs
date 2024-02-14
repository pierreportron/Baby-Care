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
        HINT
    }

    public StringToShow str;


    void Update()
    {
        currentTask = TaskManager.instance.taskList.Find(task => task.state == Task.TaskProgress.AVAILABLE);
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();

        if(currentTask != null)
        {
            switch (str)
            {
                case StringToShow.DESCRIPTION:
                    textMesh.text = "�tape " + (currentTask.id + 1) + " :\n" + currentTask.description;
                    break;

                case StringToShow.HINT:
                    textMesh.text = currentTask.hint;
                    break;

            }
        }

        if (TaskManager.instance.AreAllTasksCompleted())
        {
            switch (str)
            {
                case StringToShow.DESCRIPTION:
                    textMesh.text = "Toutes les t�ches sont compl�t�es. Atelier 2 termin� !";
                    break;

                case StringToShow.HINT:
                    this.gameObject.transform.parent.gameObject.SetActive(false);
                    break;
            }
        }
        

    }
}
