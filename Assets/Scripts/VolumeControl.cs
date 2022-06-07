using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] string MasterVol = "MasterVol";
    [SerializeField] string MusicVol = "MusicVol";
    [SerializeField] string EffectsVol = "EffectsVol";

    [SerializeField] float _multiplier = 30f;

    public AudioMixer MainMixer;

    [SerializeField] Slider MasterSlider;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider EffectsSlider;

    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat(MasterVol, MasterSlider.value);
        Audio_Awake();
    }

    private void Audio_Awake()
    {
        MasterSlider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(MasterVol, MasterSlider.value);
    }

    private void HandleSliderValueChanged(float value)
    {
        Debug.Log("Slider change");
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Slider value = " + MasterSlider.value;
        Debug.Log(sliderMessage);
       // MainMixer.SetFloat(MasterVol, value: Mathf.Log10(MasterSlider.value) * _multiplier);
        MainMixer.SetFloat(MasterVol, value: MasterSlider.value);

    }

}