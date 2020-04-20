using UnityEngine;

public class MenuCinematic : MonoBehaviour
{
    public Transform target;
    public Vector3 Offset;

    void Start()
    {
        Time.timeScale = 1f;
        transform.position = Offset;
    }

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 30 * Time.deltaTime);
    }
}
