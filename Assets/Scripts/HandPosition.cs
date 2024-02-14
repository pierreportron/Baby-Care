using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Autohand;
using ToonBabies;
using UnityEngine.UI;
public class HandPosition : MonoBehaviour
{
    private int nbHandsOnBaby = 0;
    private float distanceHead = 100;
    private float distanceAss = 100;
    public TMP_Text text;
    public GameObject panel;
    private int timerCounter = 10;
    private int errorCounter = 0;
    public GameObject UI;
    public GameObject PanelRappel;

    public bool babyCalmed = false;
    void Start()
    {
        var grabbable = GetComponent<Grabbable>();
        grabbable.OnGrabEvent += OnGrab;
        grabbable.OnReleaseEvent += OnRelease;
        InvokeRepeating("UpdateCounter", 1.0f, 1.0f);
    }

    void OnGrab(Hand hand, Grabbable grab)
    {
        nbHandsOnBaby++;
        Vector3 backhead = GameObject.Find("first hand").transform.position;
        Vector3 ass = GameObject.Find("second hand").transform.position;
        float distanceToHead = Vector3.Distance(hand.transform.position, backhead);
        float distanceToAss = Vector3.Distance(hand.transform.position, ass);
        distanceHead = distanceToHead < distanceHead ? distanceToHead : distanceHead;
        distanceAss = distanceToAss < distanceAss ? distanceToAss : distanceAss;
    }

    void OnRelease(Hand hand, Grabbable grab)
    {
        nbHandsOnBaby--;
        Vector3 backhead = GameObject.Find("first hand").transform.position;
        Vector3 ass = GameObject.Find("second hand").transform.position;
        float distanceToHead = Vector3.Distance(hand.transform.position, backhead);
        float distanceToAss = Vector3.Distance(hand.transform.position, ass);
        if (Mathf.Abs(distanceHead - distanceToHead) < 0.05)
        {
            distanceHead = 100;
        }
        else
        {
            distanceAss = 100;
        }
    }

    void UpdateCounter()
    {
        float babySpeed = GetComponent<Rigidbody>().velocity.magnitude;
        if (timerCounter < 1)
        {
            text.text = "Bravo ! Déposez le bébé sur la table à langer.";
            Image panelImage = panel.GetComponent<Image>();
            panelImage.color = Color.green;
            GetComponent<Playanimation>().playtheanimation("TB_laugh");
            babyCalmed = true;
            PanelRappel.SetActive(false);
        }
        else if (errorCounter >= 2)
        {
            UI.SetActive(true);
            GameObject.Find("David").SetActive(false);
        }
        else if (nbHandsOnBaby == 2 && babySpeed < 0.5 && distanceHead < 0.15 && distanceAss < 0.15)
        {
            timerCounter--;
            text.text = "Parfait\n" + timerCounter;
            Image panelImage = panel.GetComponent<Image>();
            panelImage.color = Color.green;
        }
        else if (distanceAss > 0.15 || distanceHead > 0.15)
        {
            text.text = "Vous ne tenez pas bien le bébé";
            Image panelImage = panel.GetComponent<Image>();
            panelImage.color = Color.yellow;
        }
        else if (babySpeed > 1.2)
        {
            text.text = "Violent";
            Image panelImage = panel.GetComponent<Image>();
            panelImage.color = Color.red;
            errorCounter++;
        }
        else if (nbHandsOnBaby == 2 && babySpeed >= 0.5 && babySpeed <= 1.2 && distanceHead < 0.15 && distanceAss < 0.15)
        {
            text.text = "Bien";
            Image panelImage = panel.GetComponent<Image>();
            panelImage.color = Color.blue;
        }
    }

}
