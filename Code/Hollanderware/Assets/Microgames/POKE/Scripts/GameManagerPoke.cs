using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerPoke : MonoBehaviour
{
    public bool playerWin = false;
    public bool playerLose = false;

    SpriteRenderer winScreen;
    SpriteRenderer loseScreen;

    void Start()
    {
        winScreen = GameObject.Find("CheckSprite").GetComponent<SpriteRenderer>();
        loseScreen = GameObject.Find("CrossSprite").GetComponent<SpriteRenderer>();
        winScreen.enabled = false;
        loseScreen.enabled = false;
    }

    void Update()
    {
        if (playerWin && !playerLose)
        {
            winScreen.enabled = true;
            Debug.Log("Sprite shall appear");
        }

        if (playerLose && !playerWin)
        {
            loseScreen.enabled = true;
            Debug.Log("Sprite shall appear");
        }
    }

    void OnGUI()
    {
        if (playerWin || playerLose)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Retry?"))
            {
                RestartLevel();
            }
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    // Public method made for change channel to update win screen.
    public void setPlayerWinToTrue()
    {
        playerWin = true;

    }

    public void setPlayerLoseTrue()
    {
        playerLose = true;
    }
}
