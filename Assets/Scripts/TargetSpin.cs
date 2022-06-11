using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpin : MonoBehaviour
{
    [SerializeField] float spinSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinSpeed, 0);
    }
}
