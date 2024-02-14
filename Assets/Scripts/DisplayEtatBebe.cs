using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Displayetatbébé : MonoBehaviour
{
    public GameObject objetetat;
    public float etat;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        etat = objetetat.GetComponent<EtatBebe>().etat;
        string texte="";
        
        switch (etat)
        {
            case 0:
                texte="Parfait";
                break;
            case 1:
                texte="bon";
                break;
            case 2:
                texte="Mauvaise position";
                break;
            case 3:
                texte="Hors du lit";
                break;
        }
        text.text = texte;
        



        
    }
}
