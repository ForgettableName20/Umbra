using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    private bool isLightOn;

    public UnityEvent lightOnEvent;
    public UnityEvent lightOffEvent;

    public void InteractSwitch()
    {
        if (!isLightOn)
        {
            isLightOn = true;
            lightOnEvent.Invoke();
        }
        else
        {
            isLightOn = false;
            lightOffEvent.Invoke();
        }
    }

}
