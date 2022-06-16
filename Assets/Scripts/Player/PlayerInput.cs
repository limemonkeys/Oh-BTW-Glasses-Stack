using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject Player;

    float x, y;
    bool jumping, sprinting, crouching;

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void MyInput() {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        jumping = Input.GetButton("Jump");
        crouching = Input.GetKey(KeyCode.LeftControl);
      
      /*
        //Crouching
        if (Input.GetKeyDown(KeyCode.LeftControl))
            Player.GetComponent<PlayerMovement>().StartCrouch();
        if (Input.GetKeyUp(KeyCode.LeftControl))
            Player.GetComponent<PlayerMovement>().StopCrouch();
            */
    }
}
