using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticComponent : MonoBehaviour
{
    public float hapticIntensity = 0f;
    public float hapticTime = 0f;
    [SerializeField] protected XRBaseController controller;

    public void TriggerHaptic()
    {
        if (hapticIntensity <= 0f || controller == null) return;
        controller.SendHapticImpulse(hapticIntensity, hapticTime);
    }
    public void TriggerHapticOverride(float hapticIntensity, float hapticTime)
    {
        if (hapticIntensity <= 0f || controller == null) return;
        controller.SendHapticImpulse(hapticIntensity, hapticTime);
    }
}
