using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class TutorialShades : MonoBehaviour
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
                    "By pressing 1 - 5, you'll equip 1 to 5 pairs of sunglasses.",
                    "Based on the number of sunglasses you equip, your speed will increase.",
                    "However, the more you let your speed increase the less you'll be able to see.",
                    "When you're done looking cool, run into that large wall to quit the game."
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
        TextWriter.AddWriter_Static(messageText, "Finally, let's get rad.", 0.05f, true, true, StopMewingSound);
    }

    
}

