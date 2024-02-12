using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTap : MonoBehaviour
{

    public ParticleSystem RunningWater;
    public AudioSource openSound;

    private Animator Tap;
    private bool isOpen;

    //RunningWater.Stop();
    //RunningWater.Play();

    //openSound.Play();
    //openSound.Pause();

    void Start()
    {
        Tap = this.GetComponent<Animator>();
        RunningWater.Stop();
        isOpen = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            if (!isOpen)
            {
                OpenRobinet();
                isOpen = true;
            }
            else
            {
                CloseRobinet();
                isOpen = false;
            }
            
        }
    }

    public void OpenRobinet()
    {
        Tap.ResetTrigger("Close");
        Tap.SetTrigger("Open");

        RunningWater.Play();
        openSound.Play();
    }

    public void CloseRobinet()
    {
        Tap.ResetTrigger("Open");
        Tap.SetTrigger("Close");

        RunningWater.Stop();
        openSound.Pause();
    }


}
