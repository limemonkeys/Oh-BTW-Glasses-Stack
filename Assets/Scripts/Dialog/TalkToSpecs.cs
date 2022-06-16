using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToSpecs : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject specsDialog;
    public PullDialog pullDialog;
    public PushDialog pushDialog;
    public GameObject DialogBox;
    public bool awaitingDialog;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.SetCanMove(false);
        pullDialog.ResetVars();
        
        
        awaitingDialog = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (awaitingDialog)
        {
            DialogBox.GetComponent<PushDialog>().enabled = false;
            DialogBox.GetComponent<PullDialog>().enabled = true;
            if (pullDialog.IsFinishedLerp())
            {
                specsDialog.SetActive(true);
                awaitingDialog = false;
            }
            
        }
        
        else if (!awaitingDialog && !specsDialog.activeInHierarchy && !pushDialog.IsFinishedLerp())
        {
            
            DialogBox.GetComponent<PullDialog>().enabled = false;
            DialogBox.GetComponent<PushDialog>().enabled = true;
        }
        else if (pushDialog.IsFinishedLerp())
        {
            DialogBox.GetComponent<PushDialog>().enabled = false;
            this.enabled = false;
        }
    }
    
}
