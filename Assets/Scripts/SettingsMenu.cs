using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer MainMixer;

    public void SetVolume(float volume)
    {
        MainMixer.SetFloat("MasterVol", MasterVol);
        MainMixer.SetFloat("MusicVol", MusicVol);
        MainMixer.SetFloat("EffectsVol", EffectsVol);
    }
}
