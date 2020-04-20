using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    private bool menuIsShowing = false;

    void Awake()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuIsShowing = !menuIsShowing;
            pauseMenu.SetActive(menuIsShowing);
            //Debug.Log("Pause Menu Showing:" + menuIsShowing);

            if (menuIsShowing == true)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }

    public void resetTimeScale()
    {
        Time.timeScale = 1f;
    }
}
