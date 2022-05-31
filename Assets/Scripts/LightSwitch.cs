using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    private bool isLightOn;

    public UnityEvent triggerOnEvent;
    public UnityEvent triggerOffEvent;

    public void InteractSwitch()
    {
        if (!isLightOn)
        {
            isLightOn = true;
            triggerOnEvent.Invoke();
        }
        else
        {
            isLightOn = false;
            triggerOffEvent.Invoke();
        }
    }

}
