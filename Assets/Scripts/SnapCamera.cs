using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[ExecuteInEditMode]
public class SnapCamera : MonoBehaviour
{
    public Transform playerTransform;

    private Vector3 thirdPersonCameraOffset;
    //private Vector3 firstPersonAnimationOffset;

    public bool thirdPerson = true;

    void Start()
    {
        if (PlayerPrefs.GetFloat("offsetTPVY") == 0)
        {
            PlayerPrefs.SetFloat("offsetTPVY", 6f);
        }

        if (PlayerPrefs.GetFloat("offsetTPVZ") == 0)
        {
            PlayerPrefs.SetFloat("offsetTPVZ", -7.5f);
        }

        thirdPersonCameraOffset.x = PlayerPrefs.GetFloat("offsetTPVX");
        thirdPersonCameraOffset.y = PlayerPrefs.GetFloat("offsetTPVY");
        thirdPersonCameraOffset.z = PlayerPrefs.GetFloat("offsetTPVZ");
    }
    void Update()
    {
        if (thirdPerson == true)
        {
            gameObject.transform.position = playerTransform.position + thirdPersonCameraOffset;
        }
        else
        {
            //gameObject.transform.position = playerTransform.position + firstPersonAnimationOffset;
        }
    }
}
