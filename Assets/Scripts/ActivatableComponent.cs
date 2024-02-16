using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivatableComponent : MonoBehaviour
{
    [SerializeField] protected XRGrabInteractable interactable;
    [SerializeField] protected HapticComponent haptic;
    public UnityEvent activateEvent;

    // Start is called before the first frame update
    void Start()
    {
        if (interactable == null) return;
        interactable.activated.AddListener(ActivateEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateEvent(ActivateEventArgs args)
    {
        if (activateEvent == null) return;
        if (haptic != null)
        {
            haptic.TriggerHaptic();
        }
        activateEvent.Invoke();
    }
}
