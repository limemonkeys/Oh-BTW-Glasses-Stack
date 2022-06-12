using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningStick : MonoBehaviour
{
     [SerializeField] float rotateSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, rotateSpeed);
    }
}
