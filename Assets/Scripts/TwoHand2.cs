using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHand2 : MonoBehaviour
{
    private XRController leftController;
    private XRController rightController;
    public Transform grabPoint;
    public float lerpSpeed = 10f;

    private bool isGrabbing = false;

    private void Start()
    {
        // Find XRControllers attached to this GameObject
        leftController = GetComponentInChildren<XRController>();
        rightController = GetComponentsInChildren<XRController>()[1];
    }

    private void Update()
    {
        // Check if grip buttons are pressed
        bool leftGripPressed = IsControllerButtonPressed(leftController, InputHelpers.Button.Grip);
        bool rightGripPressed = IsControllerButtonPressed(rightController, InputHelpers.Button.Grip);

        // Check if both grip buttons are pressed
        isGrabbing = leftGripPressed && rightGripPressed;

        if (isGrabbing)
        {
            // Smoothly move the object towards the grab point
            Vector3 targetPosition = grabPoint.position;
            Quaternion targetRotation = grabPoint.rotation;
            transform.position = Vector3.Lerp(transform.position, targetPosition, lerpSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, lerpSpeed * Time.deltaTime);
        }
    }

    // Method to check if a button on a controller is pressed
    private bool IsControllerButtonPressed(XRController controller, InputHelpers.Button button)
    {
        bool isPressed;
        InputHelpers.IsPressed(controller.inputDevice, button, out isPressed, 0.1f);
        return isPressed;
    }
}
