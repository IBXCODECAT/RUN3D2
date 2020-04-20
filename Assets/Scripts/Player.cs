using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody playerPhysics;

    public GameObject player;

    public float horizontalSpeed;
    public float maxForwardVelocity;
    public float forwardForce;
    public float jumpForce;
    public float loadVelocityForce;
    public bool invertControls;
    public int fallDistanceAllowed;

    [HideInInspector]
    public bool isAlive = true;

    private GameManagement gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagement>();
    }
    void Update()
    {

        if (isAlive == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");

            if (invertControls == false)
            {
                transform.position += Vector3.right * horizontalInput * horizontalSpeed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.left * horizontalInput * horizontalSpeed * Time.deltaTime;
            }
        }

        if(playerPhysics.velocity.z < maxForwardVelocity)
        {
            playerPhysics.AddForce(Vector3.forward * forwardForce * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {   
            if (transform.position.y < 1.1f)
            {
                playerPhysics.AddForce(Vector3.up * jumpForce * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            
            playerPhysics.AddForce(Vector3.forward * forwardForce * Time.deltaTime);
        }
        
        if (transform.position.y < fallDistanceAllowed)
        {
            gameManager.levelRestart(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle")
        {
            gameManager.levelRestart(true);
        }

        if (collision.gameObject.tag == "EndOfLevel")
        {
            gameManager.levelComplete();
        }
    }
}
