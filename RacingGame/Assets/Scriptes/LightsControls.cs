using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsControls : MonoBehaviour
{
    public static LightsControls instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void TurnOnLights()
    {
        gameObject.SetActive(true);
    }
    public void TurnOffLights() { gameObject.SetActive(false); }    
}
