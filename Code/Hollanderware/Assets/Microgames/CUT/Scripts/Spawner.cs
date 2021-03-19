using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bambooPrefab;
    public Transform[] spawnPoints;
    public GameObject winText;
    public GameObject failText;

    public float minDelay = 0.8f;
    public float maxDelay = 1.8f;
    public int bambooCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBamboo());
    }

    IEnumerator SpawnBamboo()
    {
        // While the game is not won or loss, loop through
        while (!winText.activeSelf && !failText.activeSelf)
        {
            // Randomly pick a delay time to spawn a new bamboo
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            // Randomly pick a bamboo spawn point
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            // Spawn the bamboo
            if (bambooCount != 7)
            {
                GameObject spawnBamboo = Instantiate(bambooPrefab, spawnPoint.position, spawnPoint.rotation);
                // Despawn after 2 seconds, to avoid clutter
                Destroy(spawnBamboo, 4f);
                bambooCount++;
            }
        }
    }
}
