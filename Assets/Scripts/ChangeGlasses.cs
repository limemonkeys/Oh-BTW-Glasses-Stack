using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
public class ChangeGlasses : MonoBehaviour
{
    public PostProcessVolume Volume;
    public ColorGrading ColorGrading;
    public TutorialPlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        Volume.profile.TryGetSettings(out ColorGrading);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = 0f;     
            playerMovement.setMoveSpeed(4500f);       
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -50f;  
            playerMovement.setMoveSpeed(5500f); 
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -70f;
            playerMovement.setMoveSpeed(6500f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -80f;   
            playerMovement.setMoveSpeed(7500f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -85f;   
            playerMovement.setMoveSpeed(8500f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Volume.profile.TryGetSettings(out ColorGrading);
            ColorGrading.brightness.value = -90f;   
            playerMovement.setMoveSpeed(9500f);
        }

    }
}
