using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class TownWelcome : MonoBehaviour
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
                    "Once you exit this introduction, you can move around using WASD",
                    "You can jump using Space. You can crouch using CTRL.",
                    "If you press CTRL while moving, you'll slide!",
                    "There's also wall running. All you have to do is jump at a wall while you're moving",
                    "You can access your inventory using TAB and look at the unfinished menu using ESC.",
                    "A shop can be accessed by pressing x, however you can't buy anything yet.",
                    "Try playing one of the target elimination levels by entering the purple portal."
                };
                if (messageIndex >= messageArray.Length)
                {
                    //All text finished
                    PlayerCapsule.GetComponent<Rigidbody>().isKinematic = false;
                    gameManager.SetCanMove(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    transform.gameObject.SetActive(false);
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
        gameManager.SetCanMove(false);
        messageIndex = 0;
        // Write this message at a speed of 1 char per sec
        TextWriter.AddWriter_Static(messageText, "Welcome to Oh BTW Glasses Stack! Click this textbox to continue.", 0.05f, true, true, StopMewingSound);
    }

    
}

