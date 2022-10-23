using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer BGMMixer;
    public AudioMixer SFXMixer;
    [Space(10)]
    public Slider BGMSlider;
    public Slider SFXSlider;

    public void SetBgmVolume(float volume)
    {
        BGMMixer.SetFloat("BgmVolume", volume);
    }

    public void SetSFXSistem(float volume1)
    {
        SFXMixer.SetFloat("SistemVolume", volume1);
    }

    private void OnEnable()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BgmVolume", 0);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", 0);
    }
    private void OnDisable()
    {
        float BGMAudio = 0;
        float SFXVolume = 0;

        BGMMixer.GetFloat("BgmVolume", out BGMAudio);
        SFXMixer.GetFloat("SFXVolume", out SFXVolume);

        PlayerPrefs.SetFloat("BgmVolume", BGMAudio);
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume);

        PlayerPrefs.Save();
    }
}
