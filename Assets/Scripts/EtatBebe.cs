using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtatBebe : MonoBehaviour
{
    private GameObject bebe;
    public int etat;
    public float position;
    public bool inBed;
    public GameObject menufin;

    // Start is called before the first frame update
    void Start()
    {
        bebe = gameObject;
        inBed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inBed)
        {

            if (convertir(bebe.transform.localRotation.eulerAngles.x) >= -100 && convertir(bebe.transform.localRotation.eulerAngles.x) <= -80)
            {
                etat = 0;
                menufin.SetActive(true);
            }
            else if (convertir(bebe.transform.localRotation.eulerAngles.x) >= -110 && convertir(bebe.transform.localRotation.eulerAngles.x) <= -70)
            {
                etat = 1;
            }
            else
            {
                etat = 2;
                
            }
        }
        else
        {
            etat = 3;
        }
        position=convertir(bebe.transform.localRotation.eulerAngles.x);
    }
    private float convertir(float angle)
    {
        if (angle > 180)
        {
            return angle - 360;
        }
        return angle;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bed")
        {
            inBed = true;
            Debug.Log("inBed");
        }
    }
        private void OnTriggerExit(Collider other)
    {
        if ( other.gameObject.tag == "Bed")
        {
            inBed = false;
        }
    }
    public int getEtat()
    {
        return etat;
    }   
}
