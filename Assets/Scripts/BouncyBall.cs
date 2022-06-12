using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(moveSpeed, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Target") {
            moveSpeed = moveSpeed * -1;
        } 
    }
}
