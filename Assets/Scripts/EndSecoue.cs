using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToonBabies;
using TMPro;
public class EndSecoue : MonoBehaviour
{
    public GameObject UI;
    public TMP_Text text;
    public GameObject David_2;
    public GameObject Canva_eval;
    public GameObject Canva_intro;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "David")
        {
            collision.gameObject.SetActive(false);
            UI.SetActive(true);
            text.text = "Bravo !! Vous avez complété cet atelier !";
            David_2.SetActive(true);
            Canva_eval.SetActive(false);
            Canva_intro.SetActive(false);
        }
    }

}
