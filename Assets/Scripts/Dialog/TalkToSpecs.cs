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
    //public GameObject Dialogs;
    public bool awaitingDialog;

    // Start is called before the first frame update
    void Start()
    {
        gameManager.SetCanMove(false);
        pullDialog.ResetVars();
        awaitingDialog = true;
    }

    void ResetDialog()
    {

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
                /*
                GameObject originalGameObject = GameObject.Find(specsDialog.name);
                Instantiate(originalGameObject);
                specsDialog = GameObject.Find(specsDialog.name + "(Clone)");
                */
                awaitingDialog = false;
            }
            
        }
        
        else if (!awaitingDialog && !specsDialog.activeInHierarchy && !pushDialog.IsFinishedLerp())
        {
            
            DialogBox.GetComponent<PullDialog>().enabled = false;
            DialogBox.GetComponent<PushDialog>().enabled = true;
        }
        else if (pushDialog.IsFinishedLerp() && this.enabled)
        {
            DialogBox.GetComponent<PushDialog>().enabled = false;
            /*
            GameObject originalGameObject = GameObject.Find(specsDialog.name);
            originalGameObject.SetActive(false);
            Instantiate(originalGameObject);
            print(originalGameObject.name);
            specsDialog = GameObject.Find(specsDialog.name + "(Clone)");
            originalGameObject.SetActive(true);
            */
            //GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            this.enabled = false;
        }
    }

    public void EnableWaitForDialog()
    {
        awaitingDialog = true;
    }
    

}
