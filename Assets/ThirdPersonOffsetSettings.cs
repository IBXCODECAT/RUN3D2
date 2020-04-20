using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonOffsetSettings : MonoBehaviour
{
    private Slider offsetSlider;
    public string sliderName;

    void Start()
    {
        offsetSlider = GetComponent<Slider>();
        offsetSlider.value = PlayerPrefs.GetFloat(sliderName);
    }

    public void cameraOffsetChanger()
    {
        PlayerPrefs.SetFloat(sliderName, offsetSlider.value);
    }
}
