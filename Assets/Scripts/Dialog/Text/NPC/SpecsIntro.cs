using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class SpecsIntro : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private AudioSource mewingAudioSource;
    private int messageIndex;
    public GameManager gameManager;
    public GameObject PlayerCapsule;
    public GameObject characterPortait;
    
    public PushDialog pushDialog;
    public PullDialog pullDialog;

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
                    "You can find today's special on the sign next to me."
                };
                if (messageIndex >= messageArray.Length)
                {
                    //All text finished
                    PlayerCapsule.GetComponent<Rigidbody>().isKinematic = false;
                    gameManager.SetCanMove(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    pushDialog.ResetVars();
                    pullDialog.ResetVars();
                    characterPortait.SetActive(false);
                    transform.gameObject.SetActive(false);
                    //this.enabled = false;
                    //Instantiate(this);
                    //Destroy(gameObject);
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
        print(messageIndex);
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
        print("Starting Specs intro");
        gameManager.SetCanMove(false);
        messageIndex = 0;
        // Write this message at a speed of 1 char per sec
        TextWriter.AddWriter_Static(messageText, "What's up buddy? Need some glasses? Check out my wears!", 0.05f, true, true, StopMewingSound);
    }
    
}
