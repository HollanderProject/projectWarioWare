using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CountdownHERD : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject failText;
    public GameObject winText;
    SpriteRenderer loseScreen;
    public float time;
    void Start()
    {
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
            failText.SetActive(true);
            loseScreen.enabled = true;
            GameManagerHERD.playerLose = true;
            SheepMove.forcePower = 0;
            PigMove.forcePower = 0;
            CowMove.forcePower = 0;
        }
    }

}