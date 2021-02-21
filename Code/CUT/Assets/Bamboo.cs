using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo : MonoBehaviour
{
    public GameObject winText;
    public GameObject failText;
    public GameObject bamboo;
    void start()
    {
        winText.SetActive(false);
        failText.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Scissors")
        {
            winText.SetActive(true);
            bamboo.GetComponent<Rigidbody2D>().gravityScale = 0;
            bamboo.SetActive(false);
            Debug.Log("Collision detected.");
        }
    }
}
