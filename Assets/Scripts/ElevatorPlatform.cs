using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float maxHeight = 10f;
    [SerializeField] float minHeight = 1f;

    [SerializeField]
    bool goingUp = true;
    bool isWaiting = false;

    // Update is called once per frame
    void Update() {
        float liftHeight = getLiftHeight();
        if (!isWaiting) { // check if waiting == false 
            if (liftHeight <= maxHeight && goingUp) {
                gameObject.transform.Translate(0, moveSpeed, 0);
            } else if (liftHeight >= minHeight && !goingUp) {
                gameObject.transform.Translate(0, -moveSpeed, 0);
            } else {
                goingUp = !goingUp;
                StartCoroutine(Wait()); // start the coroutine to wait
            }
        }
    }

    float getLiftHeight() {
        return this.transform.position.y;
    }

    IEnumerator Wait()
    {  
        isWaiting = true;  //set the bool to stop moving
        print("Start to wait");
        yield return new WaitForSeconds(3); // wait for 3 sec
        print("Wait complete");
        isWaiting = false; // set the bool to start moving
    }

}
