using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMasterVol (float MasterVolume)
    {
        audioMixer.SetFloat("MasterVol", MasterVolume);
    }

}