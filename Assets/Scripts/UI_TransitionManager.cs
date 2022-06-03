using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class UI_TransitionManager : MonoBehaviour
{

    public CinemachineVirtualCamera currentCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        currentCamera.Priority++;
    }

    
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        currentCamera.Priority--;
        currentCamera = target;
        currentCamera.Priority++;
    }
}
