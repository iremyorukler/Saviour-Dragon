using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 1.5f; 
    public float deadZone = -15f; 

    void Update()
    {
        // Sola git
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}