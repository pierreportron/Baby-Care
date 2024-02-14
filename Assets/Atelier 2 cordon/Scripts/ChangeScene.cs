using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GotoMenu()
    {
        Debug.Log("Go to Menu scene ...");
        SceneManager.LoadScene("Menu");
        
    }

    public void Restart()
    {
        Debug.Log("Restart ...");
        SceneManager.LoadScene("Atelier_cordon");

    }

    public void GoToWorshop3()
    {
        Debug.Log("Go to Atelier 3 scene ...");
        SceneManager.LoadScene("Atelier_Sommeil");
    }
}
