using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement instance;

    public GameObject player;
    public Transform playerPosition;
    public Rigidbody playerPhysics;
    public int playerCrashForce;
    public int delayBeforeRestart;

    private Coroutine restartLevel;


    public Player playerControlScript;

    void Start()
    {
        player.GetComponent<Player>();
    }


    bool randomBoolean()
    {
        if (Random.value >= 0.5)
        {
            return true;
        }
        return false;
    }

    public int GetCurrentLevel(bool getNext)
    {
        if (getNext == true)
        {
            return SceneManager.GetActiveScene().buildIndex + 1;
        }
        else
        {
            return SceneManager.GetActiveScene().buildIndex;
        }
    }

    public void levelComplete()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("currentLevel", sceneIndex);
        SceneManager.LoadScene(sceneIndex);

    }

    public void levelRestart(bool disableMovementOnCollision)
    {

        if (disableMovementOnCollision == true)
        {
            playerControlScript.isAlive = false;
            playerPhysics.constraints = RigidbodyConstraints.None;
        }

        if (restartLevel == null)
        {
            restartLevel = StartCoroutine(restartDelay());

            if (randomBoolean() == true)
            {
                for (int i = 0; i < playerCrashForce; i++)
                {
                    playerPhysics.AddForce(Vector3.left * playerPhysics.velocity.x * playerCrashForce * Time.deltaTime);
                }
            }
            else
            {
                for (int i = 0; i < playerCrashForce; i++)
                {
                    playerPhysics.AddForce(Vector3.right * playerPhysics.velocity.x * playerCrashForce * Time.deltaTime);
                }
            }            
        }
    }
    IEnumerator restartDelay()
    {
        //Debug.Log("restart corutine activated");
        yield return new WaitForSeconds(delayBeforeRestart);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
