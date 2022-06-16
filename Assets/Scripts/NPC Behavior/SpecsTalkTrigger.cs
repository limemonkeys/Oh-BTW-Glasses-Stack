using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecsTalkTrigger : MonoBehaviour, IInteractable
{
    public TalkToSpecs TalkToSpecs;
    public PullDialog pullDialog;
    public PushDialog pushDialog;
    public bool hadFirstInteraction;

    void Start()
    {
        hadFirstInteraction = false;
    }

    public string GetDescription()
    {
        return "Talk to Specs.";
    }

    public void Interact()
    {
        //if (hadFirstInteraction)
        //{
            
        //}
        TalkToSpecs.EnableWaitForDialog();
        pullDialog.ResetVars();
        //pushDialog.ResetVars();
        TalkToSpecs.enabled = true;
    }
}
