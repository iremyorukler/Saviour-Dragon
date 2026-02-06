using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength = 10;
    public bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Dragon is ready!");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity=Vector2.up* flapStrength;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly"))
        {
            GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Puan alma kýsmý
        if (other.gameObject.CompareTag("Score"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.IncreaseScore();
            }
        }
    }

    void GameOver()
    {
        isDead = true;
        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver();
        }
    }
}