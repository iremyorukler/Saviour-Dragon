using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; 

    public float spawnRate = 2f;  
    public float heightOffset = 2f;

    public int totalPipes = 10;   
    private int pipesSpawned = 0; 
    private float timer = 0;
    public bool isLevelFinished = false; 

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (isLevelFinished == true)
        {
            return;
        }

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        if (pipesSpawned >= totalPipes)
        {
            isLevelFinished = true;
            return;
        }


        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        float randomY = Random.Range(lowestPoint, highestPoint);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);

        Instantiate(pipePrefab, spawnPosition, transform.rotation);

        pipesSpawned = pipesSpawned + 1;
    }
}