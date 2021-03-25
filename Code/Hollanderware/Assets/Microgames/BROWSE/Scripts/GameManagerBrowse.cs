using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class GameManagerBrowse : MonoBehaviour
{
    public bool playerWin = false;
    public bool playerLose = false;

    SpriteRenderer winScreen;
    SpriteRenderer loseScreen;

    mainController.CollectionGameController _gameController;
    Scene CollectionScene;

    void Start()
    {
        winScreen = GameObject.Find("CheckSprite").GetComponent<SpriteRenderer>();
        loseScreen = GameObject.Find("CrossSprite").GetComponent<SpriteRenderer>();
        winScreen.enabled = false;
        loseScreen.enabled = false;
        try
        {
            _gameController = GameObject.Find("CollectionGameController").GetComponent<mainController.CollectionGameController>();
        }
        catch (System.Exception)
        {
            _gameController = null;
        }
        CollectionScene = SceneManager.GetSceneByBuildIndex(15);
    }

    void Update()
    {
        // Player has won!
        if (playerWin && !playerLose)
        {
            winScreen.enabled = true;
            Debug.Log("Hey?");

            if (CollectionScene.isLoaded)
            {
                StartCoroutine(WaitBeforeUnloadingScoreIncrement());
            }
        }

        // Player has lost...
        if (playerLose && !playerWin)
        {
            loseScreen.enabled = true;
            if (CollectionScene.isLoaded)
            {
                StartCoroutine(WaitBeforeUnloadingHealthDecrease());
            }
        }
    }

    void OnGUI()
    {   
        // Collection not playing. Display on screen.
        if (!CollectionScene.isLoaded)
        {
            if (playerWin || playerLose)
            {
                if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 50, 100, 100), "Level Select"))
                {
                    RestartLevel();
                }
            }
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(2);
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

    IEnumerator WaitBeforeUnloadingHealthDecrease()
    {
        yield return new WaitForSeconds(1);
        _gameController.decrementPlayerHealth();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(3);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(3);
    }
}
