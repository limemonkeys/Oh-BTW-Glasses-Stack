using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour
{
    float startTime;
    float currTime;

    public GameObject closed;
    public GameObject open;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.deltaTime;
    }
     
     void Update()
     {
        currTime += Time.deltaTime;
        if (Mathf.Abs(currTime - startTime) > 0.25f)
        {
            if (closed.activeInHierarchy)
            {
                closed.SetActive(false);
                open.SetActive(true);
            }
            else
            {
                closed.SetActive(true);
                open.SetActive(false);
            }
            startTime = currTime;
        }
     }
}
