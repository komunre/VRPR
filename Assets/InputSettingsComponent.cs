using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputSettingsComponent : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurnProvider;
    public ActionBasedContinuousTurnProvider continuousTurnProvider;

    protected bool snap = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSnap()
    {
        snap = !snap;
        ProcessSnap();
    }

    protected void ProcessSnap()
    {
        if (snap)
        {
            snapTurnProvider.enabled = true;
            continuousTurnProvider.enabled = false;
        }
        else
        {
            snapTurnProvider.enabled = false;
            continuousTurnProvider.enabled = true;
        }
    }

    public void ChangeSnap(int mode)
    {
        switch (mode)
        {
            case 0:
                snap = true;
                ProcessSnap();
                break;
            case 1:
                snap = false;
                ProcessSnap();
                break;
        }
    }
}
