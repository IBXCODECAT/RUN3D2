using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text startText;
    public RawImage nullReferenceError;

    void Start()
    {
        ShowErrors errorScript = GameObject.Find("Error Menu").GetComponent<ShowErrors>();

        if (PlayerPrefs.GetInt("currentLevel") == 0)
        {
            startText.text = "Play Game";
            PlayerPrefs.SetInt("currentLevel", 1);
        }
        else
        {
            errorScript.sendError(nullReferenceError);
            startText.text = "Load Game";
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentLevel"));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {

        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Application");
        Application.Quit();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetFloat("currentLevel", SceneManager.GetActiveScene().buildIndex);
    }
}
