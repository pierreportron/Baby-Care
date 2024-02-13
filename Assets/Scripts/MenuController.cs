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
        SceneManager.LoadScene("Atelier_cordon");
    }
    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quit()
    {
        Application.Quit();
    }
}
