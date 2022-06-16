using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSlider : MonoBehaviour
{
    public TownManager townManager;
    public GameObject Dialog;
    private bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        dialogActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (!dialogActive && townManager.getTextboxIdling())
        {
            //if (Input.GetKeyDown(KeyCode.Z) && !Dialog.GetComponent<PullDialog>().enabled)
            if (!Dialog.GetComponent<PullDialog>().enabled)
            {
                Dialog.GetComponent<PullDialog>().ResetVars();
                Dialog.GetComponent<PullDialog>().enabled = true;
            }
            if (Dialog.GetComponent<PullDialog>().IsFinishedLerp())
            {
                Dialog.GetComponent<PullDialog>().enabled = false;
                Dialog.GetComponent<PushDialog>().ResetLerp();
                dialogActive = true;
            }
        }
        //if (dialogActive && !Input.GetMouseButton(0)) 
        if (dialogActive && townManager.getTextboxIdling()) 
        {
            //if (Input.GetKeyDown(KeyCode.Z))
            if (!Dialog.GetComponent<PushDialog>().enabled)
            {
                Dialog.GetComponent<PushDialog>().ResetVars();
                Dialog.GetComponent<PushDialog>().enabled = true;
            }
            if (Dialog.GetComponent<PushDialog>().IsFinishedLerp())
            {
                Dialog.GetComponent<PushDialog>().enabled = false;
                Dialog.GetComponent<PullDialog>().ResetLerp();
                dialogActive = false;
                
            }
        }
        */
    }
}
