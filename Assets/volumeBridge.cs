using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeBridge : MonoBehaviour
{
    private Slider volumeSlider;
    public string bridgeString;

    private void Start()
    {
        volumeSlider = GetComponent<Slider>();
    }
    public void volumeChangeBridge()
    {
        AudioManager.instance.VolumeChanger(bridgeString, volumeSlider);
    }
}
