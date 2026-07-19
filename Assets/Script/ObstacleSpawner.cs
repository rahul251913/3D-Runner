using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;

    private float nextZ = 30f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-3f, 3f);

        Instantiate(
            obstaclePrefab,
            new Vector3(randomX, 1f, nextZ),
            Quaternion.identity
        );

        nextZ += 15f;   // Har obstacle pichhle se 15 units aage
    }
}