using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCanva : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pannel_intro;
    public GameObject pannel_vidéo;
    public GameObject pannel_consignes;
    public GameObject pannel_evaluation;

    public void ToVideo()
    {
        pannel_intro.SetActive(false);
        pannel_vidéo.SetActive(true);
        pannel_vidéo.GetComponent<UnityEngine.Video.VideoPlayer>().Play();

    }
    public void ToConsignes()
    {
        pannel_vidéo.SetActive(false);
        pannel_consignes.SetActive(true);
    }
    public void Fin()
    {
        pannel_consignes.SetActive(false);
        //pannel_evaluation.SetActive(false);
    }
}
