using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void toAtelierSommeil()
    {
        SceneManager.LoadScene("Atelier_Sommeil");
    }

    public void toAtelierSecoue()
    {
        SceneManager.LoadScene("Atelier_Secoue");
    }

    public void toAtelierCordon()
    {
        SceneManager.LoadScene("Atelier_Cordon");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
