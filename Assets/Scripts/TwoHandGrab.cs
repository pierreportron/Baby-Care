using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections.Generic;

public class TwoHandGrab : MonoBehaviour
{
   //public Transform FirstHand;
   //public Transform SecondHand;
   private bool rightGripPressed = false;
   private bool leftGripPressed = false;
   private List<Collider> colliders = new List<Collider>();
   public GameObject RightController;
   public GameObject LeftController;
   private XRController leftController;
   private XRController rightController;
   public TextMesh text;

    public void OnStart()
    {
        leftController = LeftController.GetComponent<XRController>();
        rightController = RightController.GetComponent<XRController>();
    }


    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "PlayerHand")
        {
            colliders.Add(collider);
            text.text = "Colliders: " + colliders.Count;
        }
    }
   /*public void OnColliderEnter(Collider collider)
   {
      if (collider.gameObject.tag == "PlayerHand")
      {
        colliders.Add(collider);
        text.text = "Colliders: " + colliders.Count;
      }
   }*/

   public void OnColliderExit(Collider collider)
   {
      if (collider.gameObject.tag == "PlayerHand")
      {
        colliders.Remove(collider);
      }
   }

   private void Update()
    {
        // Check if the grip buttons of both controllers are pressed
        leftGripPressed = IsControllerButtonPressed(leftController, InputHelpers.Button.Grip);
        rightGripPressed = IsControllerButtonPressed(rightController, InputHelpers.Button.Grip);

        // If both grip buttons are pressed, perform the two-handed grab action
        if (leftGripPressed && rightGripPressed /*&& colliders.Count >= 2*/)
        {
            transform.position = RightController.transform.position;
        }
    }

   private bool IsControllerButtonPressed(XRController controller, InputHelpers.Button button)
    {
        bool isPressed;
        InputHelpers.IsPressed(controller.inputDevice, button, out isPressed);
        return isPressed;
    }
}
