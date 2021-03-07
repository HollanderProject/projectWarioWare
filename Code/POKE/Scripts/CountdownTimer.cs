using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{
    // Create variables for what the timer should start at and the currenTime, which will countdown as the game goes on
    float currentTime = 0f;
    float startingTime = 10f;

    // Create a textfield to be changed from the options
    [SerializeField] Text countdownText;

    // Set the current time to 10 when the game starts
    void Start()
    {
        currentTime = startingTime;
    }

    // Countdown as the game goes on
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0"); 

        // Once the game reaches 3 seconds turn the text to red to indicate urgency to the player
        if (currentTime <= 3)
        {
            countdownText.color = Color.red;
        }

        // If the countdown reaches zero take the player to the losing screen
        if (currentTime <= 0)
        {
            currentTime = 0;
            ChangeScene("loseScene");
        }
        
    }

    // Load up and display the losing screen
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
