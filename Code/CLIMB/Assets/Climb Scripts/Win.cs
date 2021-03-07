using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winText;
    public GameObject failText;
    public GameObject climber;
    public GameObject victoryPose;
    public BoxCollider2D failBox;
    public BoxCollider2D winBox;

    void Start()
    {
        // Hides the win text and victory pose
        winText.SetActive(false);
        failText.SetActive(false);
        victoryPose.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Logs the hit and then stops the game, causing the win text and victory pose to occur
        Debug.Log("HIT DETECTED");
        climber.GetComponent<Rigidbody2D>().gravityScale = 0;
        climber.SetActive(false);
        if(other == winBox)
        {
            winText.SetActive(true);
            victoryPose.SetActive(true); 
        }
        else if(other == failBox)
        {
            failText.SetActive(true);
        }
        
    }
}
