using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecsTalkTrigger : MonoBehaviour, IInteractable
{
    public TalkToSpecs TalkToSpecs;


    public string GetDescription()
    {
        return "Talk to Specs.";
    }

    public void Interact()
    {
        TalkToSpecs.enabled = true;
    }
}
