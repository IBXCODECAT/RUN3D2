using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowErrors : MonoBehaviour
{
    public static ShowErrors instance;

    public void sendError(RawImage errorImage)
    {
        errorImage.gameObject.SetActive(true);
    }
}
