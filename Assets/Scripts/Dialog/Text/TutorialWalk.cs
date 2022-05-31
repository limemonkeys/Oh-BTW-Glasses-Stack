using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class TutorialWalk : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private AudioSource mewingAudioSource;
    private int messageIndex;
    public GameManager gameManager;

    private void Awake()
    {
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        transform.Find("message").GetComponent<Button_UI>().ClickFunc = () =>
        {
            if (textWriterSingle != null && textWriterSingle.IsActive())
            {
                // Test writer is active
                textWriterSingle.WriteAllAndDestroy();
            }
            else 
            {
                string[] messageArray = new string[]{
                    "Here we'll go over basic movement",
                    "You can move around using WASD",
                    "Navigate forward past these walls to advance the tutorial."
                };
                if (messageIndex >= messageArray.Length)
                {
                    //All text finished
                    gameManager.setCanMove(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Destroy(transform.gameObject);
                }
                else 
                {
                    string message = messageArray[messageIndex];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, 0.05f, true, true, StopMewingSound);
                    messageIndex += 1;
                }

                
            }
            

            
        };
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    private void StartMewingSound() 
    {
    }

    private void StopMewingSound()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager.setCanMove(false);
        messageIndex = 0;
        // Write this message at a speed of 1 char per sec
        TextWriter.AddWriter_Static(messageText, "Welcome to the tutorial for Oh BTW Glasses Stack. Click this box to continue.", 0.05f, true, true, StopMewingSound);
    }

    
}

