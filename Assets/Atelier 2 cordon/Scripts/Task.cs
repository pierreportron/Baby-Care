using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Task 
{
    public enum TaskProgress
    {
        NOT_AVAILABLE,  //player can't access it
        AVAILABLE,      //player can access it
        COMPLETED       //player has finished it
    }

    public string title;    //task name
    public int id;          //id number of the task
    public int nextTask;  //id of the next task

    public TaskProgress state;   //state of the current task
    
    public string description;      //info of the task
    public string hint;             //guide line for doing the task
    public string finish_sentence;  //text after completed the task

    

}
