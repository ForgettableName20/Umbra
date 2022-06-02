using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] string MasterVol = "MasterVolume";
    [SerializeField] string MusicVol = "MusicVolume";
    [SerializeField] string EffectsVol = "EffectsVolume";

    [SerializeField] float _multiplier = 30f;
    [SerializeField] private Toggle _toggle;

    public AudioMixer MainMixer;

    [SerializeField] Slider MasterSlider;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider EffectsSlider;

    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat(MasterVol, MasterSlider.value);
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
        MainMixer.SetFloat(MasterVol, value:Mathf.Log10(value) * _multiplier);
    }

}