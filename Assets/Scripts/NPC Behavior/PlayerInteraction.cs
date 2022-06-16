using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Code Sourced from . killereks on YouTube
//Channel https://www.youtube.com/watch?v=hVkosA9kFg0

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 2f;

    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;

    public PullDialog pullDialog;
    public PushDialog pushDialog;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        InteractionRay();
    }

    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one/2f);
        RaycastHit hit;
 
        bool hitSomething = false;
 
        if (Physics.Raycast(ray, out hit, interactionDistance)) {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
 
            if (interactable != null) {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();
 
                if (Input.GetKeyDown(KeyCode.E) && pushDialog.IsFinishedLerp()) {
                    interactable.Interact();
                }
            }
        }

        if (!gameManager.CanMove())
        {
            hitSomething = false;
        }
 
            
        interactionUI.SetActive(hitSomething);
    }
}
