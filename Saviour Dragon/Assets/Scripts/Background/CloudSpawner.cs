using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab; 

    public float spawnRateMin = 2f; 
    public float spawnRateMax = 5f; 

    private float timer = 0;
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        SpawnCloud(); 
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            SpawnCloud();
            SetRandomTime(); 
            timer = 0;
        }
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(spawnRateMin, spawnRateMax);
    }

    void SpawnCloud()
    {
        float randomY = Random.Range(0.5f, 1.5f);

        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        Instantiate(cloudPrefab, spawnPos, transform.rotation);
    }
}