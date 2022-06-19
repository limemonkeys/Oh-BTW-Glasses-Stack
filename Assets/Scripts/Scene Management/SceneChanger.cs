using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public ItemStorage itemStorage;
    public ItemTracker itemTracker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            itemTracker.SaveEquips(itemStorage.GetItems());
            DontDestroyOnLoad(itemTracker);
            SceneManager.LoadScene("ElimGrounds1");
        }
    }
}
