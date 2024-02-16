using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty pokeAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pinch = pinchAnimationAction.action.ReadValue<float>();
        //var poke = pokeAnimationAction.action.ReadValue<float>();
        var grip = gripAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", pinch);
        handAnimator.SetFloat("Grip", grip);
    }
}
