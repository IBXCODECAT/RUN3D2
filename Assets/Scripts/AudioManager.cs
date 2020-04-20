using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    public static AudioManager instance;

    public AudioMixerGroup master;
    public AudioMixerGroup music;
    public AudioMixerGroup sound;

    private GameManagement gameManager;

    public AudioMixer mixer;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void VolumeChanger(string sliderType, Slider volumeSlider)
    {
        PlayerPrefs.SetFloat(sliderType, volumeSlider.value);
        mixer.SetFloat(sliderType, volumeSlider.value);
    }
}