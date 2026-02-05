using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Dragon is ready!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity=Vector2.up* flapStrength;
        }
        
    }
}
