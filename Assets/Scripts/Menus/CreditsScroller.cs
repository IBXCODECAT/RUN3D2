using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsScroller : MonoBehaviour
{

    public AudioSource credits;
    public Button backToMenu;
    public Text title;
    public Text subTeams;
    public Text names;

    public int scrollSpeed;

    void Update()
    {
        if (credits.isPlaying)
        {
            title.transform.position += Vector3.up * scrollSpeed * Time.deltaTime;
            subTeams.transform.position += Vector3.up * scrollSpeed * Time.deltaTime;
            names.transform.position += Vector3.up * scrollSpeed * Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
