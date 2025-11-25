using System.Collections;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] balloons;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // spawn balloon at random point with delay
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.0f, 1.0f));

        int randomBalloonIndex = Random.Range(0, balloons.Length);
        int randomSpawnPointsIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(balloons[randomBalloonIndex], spawnPoints[randomSpawnPointsIndex].position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
}
