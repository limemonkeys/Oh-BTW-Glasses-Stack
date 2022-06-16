using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeTown : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject firstTimeTownDialog;
    public PullDialog pullDialog;
    public PushDialog pushDialog;
    public GameObject DialogBox;
    public bool awaitingDialog;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.SetCanMove(false);
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
                firstTimeTownDialog.SetActive(true);
                awaitingDialog = false;
            }
            
        }
        else if (!awaitingDialog && !firstTimeTownDialog.activeInHierarchy && !pushDialog.IsFinishedLerp())
        {
            DialogBox.GetComponent<PullDialog>().enabled = false;
            DialogBox.GetComponent<PushDialog>().enabled = true;
        }
        else if (pushDialog.IsFinishedLerp())
        {
            DialogBox.GetComponent<PushDialog>().enabled = false;
        }
    }
}
