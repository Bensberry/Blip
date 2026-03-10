using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    public float spawnRate = 5f; // Adjust as needed
    private float timer = 0;

    public float heightOffset = 5f; // Adjust for vertical variation

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }

    void SpawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
    }
}

