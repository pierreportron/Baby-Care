using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;

    public List<Task> taskList = new List<Task>(); //all the tasks of the workshop to do

    //public GameObject[] textsEnd;
    public GameObject CanvasButtons;

    void Awake()
    {
        //singleton
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        /*
        foreach(GameObject textEnd in textsEnd)
        {
            textEnd.SetActive(false);
        }*/

        CanvasButtons.SetActive(false);
        //DontDestroyOnLoad(gameObject); //dont destroy between scenes
    }

    public void UpdateTaskState(int taskId)
    {
        Debug.Log("updating task state ...");
        Task currentTask = taskList.Find(task => task.id == taskId);

        if (currentTask != null)
        {
            currentTask.state = Task.TaskProgress.COMPLETED; //the current is being completed
            Debug.Log("Task id:" + taskId + " is completed");

            /*foreach (GameObject textEnd in textsEnd)
            {
                textEnd.GetComponent<TextMeshProUGUI>().text = currentTask.finish_sentence;
                textEnd.SetActive(true);
            }*/

            Debug.Log("Next task is " + currentTask.nextTask);

            //the next one is being available :
            if (currentTask.nextTask != -1) //verify if there is a next task
            {
                Task nextTask = taskList.Find(task => task.id == currentTask.nextTask);
                if (nextTask != null)
                {
                    nextTask.state = Task.TaskProgress.AVAILABLE;

                    Debug.Log("Task id:" + nextTask.id + " is available");
                }
            }
        }

    }

    //to call at the end of the final task
    public bool AreAllTasksCompleted()
    {
        return taskList.TrueForAll(task => task.state == Task.TaskProgress.COMPLETED);
    }

    public void CloseWorkshop()
    {
        Debug.Log("Toutes les tâches sont complétées. Atelier 2 terminé !");

        //show buttons to go to scene menu OR go to scene atelier 3
        CanvasButtons.SetActive(true);
    }


    public Task CurrentTask()
    {
        return taskList.Find(task => task.state == Task.TaskProgress.AVAILABLE); //find the task in the list where the state = AVAILABLE
    }

    public bool isAvailable(int taskID)
    {
        Task thistask = taskList.Find(task => task.id == taskID); //find in the list the corresponding task according to the id
        
        return (thistask.state == Task.TaskProgress.AVAILABLE) ? true : false;
    }


    void Update()
    {
        if (AreAllTasksCompleted())
        {
            CloseWorkshop();
        }
    }



}
