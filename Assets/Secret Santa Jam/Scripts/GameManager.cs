using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool canMove = false;

    public GameObject Tutorial1;

    void Start() 
    {
        Tutorial1.SetActive(true);
    }

    void Update()
    {
        
    }

    public bool CanMove()
    {
        return canMove;
    }

    public void setCanMove(bool canMove) 
    {
        this.canMove = canMove;
    }

}
