using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawn : MonoBehaviour
{

    public GameObject gemPrefab;
    float randX;
    Vector2 spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        randX = Random.Range(-5.4f, 5.4f);
        spawnPoint = new Vector2(randX, transform.position.y);
        Instantiate(gemPrefab, spawnPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
