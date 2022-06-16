using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManager : MonoBehaviour
{
    public bool textboxPulling;
    public bool textboxPushing;
    public bool textboxIdling;

    // Start is called before the first frame update
    void Start()
    {
        textboxPulling = false;
        textboxPushing = false;
        textboxIdling = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getTextboxPulling()
    {
        return textboxPulling;
    }

    public bool getTextboxPushing()
    {
        return textboxPushing;
    }

    public bool getTextboxIdling()
    {
        return textboxIdling;
    }

    public void setTextboxPulling(bool textboxPulling)
    {
        this.textboxPulling = textboxPulling;
    }

    public void setTextboxPushing(bool textboxPushing)
    {
        this.textboxPushing = textboxPushing;
    }

    public void setTextboxIdling(bool textboxPushing)
    {
        this.textboxIdling = textboxPushing;
    }
}
