using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRayInteractor;
    public XRController rightTeleportRayInteractor;
    public InputHelpers.Button teleportActivateButton;
    public float activationThreshold;
    void Update()
    {
        if (leftTeleportRayInteractor)
        {
            leftTeleportRayInteractor.gameObject.SetActive(CheckIfActivated(leftTeleportRayInteractor));
        }
        if (rightTeleportRayInteractor)
        {
            rightTeleportRayInteractor.gameObject.SetActive(CheckIfActivated(rightTeleportRayInteractor));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivateButton, out bool isActivated,
            activationThreshold);
        return isActivated;
    }
}
