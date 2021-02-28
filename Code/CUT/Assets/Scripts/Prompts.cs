using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompts : MonoBehaviour
{
    public GameObject WinText;
    public GameObject FailText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial prompts for the game
        WinText.SetActive(true);
        FailText.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // When the blade detects a collision
        if (collision.tag == "Scissors")
        {
            Debug.Log("Collision detected.");
            WinText.SetActive(true);
        }
    }
}
