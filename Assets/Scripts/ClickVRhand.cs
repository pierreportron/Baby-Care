using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickVRhand : Button
{

    [SerializeField] private Button button;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerHand")
        {
            button.onClick.Invoke();
        }
    }
}
