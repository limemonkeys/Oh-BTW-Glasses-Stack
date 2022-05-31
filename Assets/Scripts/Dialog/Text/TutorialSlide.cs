using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class TutorialSlide: MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private AudioSource mewingAudioSource;
    private int messageIndex;
    public GameManager gameManager;
    public GameObject PlayerCapsule;

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
                    "Get moving forward and when you're ready to slide press and hold CTRL"
                };
                if (messageIndex >= messageArray.Length)
                {
                    //All text finished
                    PlayerCapsule.GetComponent<Rigidbody>().isKinematic = false;
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
        TextWriter.AddWriter_Static(messageText, "Awesome. Now try sliding under an object.", 0.05f, true, true, StopMewingSound);
    }

    
}

