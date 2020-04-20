using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSettings : MonoBehaviour
{
    public void ResetMeSettings()
    {
        PlayerPrefs.DeleteKey("offsetTPVX");
        PlayerPrefs.DeleteKey("offsetTPVY");
        PlayerPrefs.DeleteKey("offsetTPVZ");
        PlayerPrefs.DeleteKey("MasterVolume");
        PlayerPrefs.DeleteKey("MusicVolume");
        PlayerPrefs.DeleteKey("SoundVolume");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
