using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Countdown : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject failText;
    public GameObject winText;
    public GameObject scissors;
    public GameObject Bamboo;
    SpriteRenderer loseScreen;
    GameManagerCUT _gameManager;
    public float time;
    public int count = 0;
    void Start()
    {
        _gameManager = GameObject.Find("GameManagerCut").GetComponent<GameManagerCUT>();
        loseScreen = GameObject.Find("CrossSprite").GetComponent<SpriteRenderer>();
        loseScreen.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the time is greater than 1 and that the winText is not active
        if (time > 0 && !winText.activeSelf)
        {
            // Counts down time and displays it
            time -= Time.deltaTime;
            timerText.text = ((int)time).ToString();
            // if the timer is <= 3, turn the timer text to red
            if (time <= 3 && !winText.activeSelf)
            {
                timerText.color = Color.red;
            }
        }
        // If the time hits 0, fail the player
        else if (time <= 0 && !winText.activeSelf)
        {
            // Creates a failure state if time hits 0
            _gameManager.setPlayerLoseTrue();
            loseScreen.enabled = true;
            failText.SetActive(true);
            Bamboo.SetActive(false);
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("Bamboo"))
            {
                Destroy(gameObj);
            }
        }
    }

}
