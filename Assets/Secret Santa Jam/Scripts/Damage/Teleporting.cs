//https://www.youtube.com/watch?v=WzzxjFD6-Mg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;

    void OnTriggerEnter(Collider other) 
    {
        player.transform.position = teleportTarget.transform.position;
    }
}
