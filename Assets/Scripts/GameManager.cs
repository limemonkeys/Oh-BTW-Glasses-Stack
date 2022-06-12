using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool canMove;
    public bool firstTimeTown;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        firstTimeTown = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CanMove()
    {
        return canMove;
    }

    public void SetCanMove(bool canMove)
    {
        this.canMove = canMove;
    }

    public bool isFirstTimeTown()
    {
        return firstTimeTown;
    }

    public void setFirstTimeTown(bool firstTimeTown)
    {
        this.firstTimeTown = firstTimeTown;
    }
}
