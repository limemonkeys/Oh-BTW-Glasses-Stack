using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject DialogToTrigger;
    public GameObject TriggerObject;
    public GameObject PlayerCapsule;
    public TutorialPlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCapsule.GetComponent<Rigidbody>().isKinematic = true;
            if (playerMovement.isCrouching() && playerMovement.CanStand())
            {
                playerMovement.StopCrouch();
            }
            
            DialogToTrigger.SetActive(true);
            Destroy(TriggerObject);
        }
    }
}
