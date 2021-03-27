using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class GameManagerCATCH : MonoBehaviour
{
    public static bool playerWin = false;
    public static bool playerLose = false;
    
    mainController.CollectionGameController _gameController;
    Scene CollectionScene;

    SpriteRenderer loseScreen;
    SpriteRenderer winScreen;

    void Start()
    {
        playerWin = false;
        playerLose = false;
        winScreen = GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>();
        loseScreen = GameObject.Find("CrossSpriteCATCH").GetComponent<SpriteRenderer>();
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
        if (CollectionScene.isLoaded)
        {
            if (playerWin && !playerLose)
            {
                
                StartCoroutine(WaitBeforeUnloadingScoreIncrement());
            }

            if (!playerWin && playerLose)
            {
                
                StartCoroutine(WaitBeforeUnloadingHealthDecrease());
            }
        }
    }

    void OnGUI()
    {
        if (!CollectionScene.isLoaded)
        {
            if (playerWin == true)
            {
                winScreen.enabled = true;
                if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Level Select"))
                {
                    RestartLevel();
                }
            }
            if (playerLose == true)
            {
                loseScreen.enabled = true;
                if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Level Select"))
                {
                    RestartLevel();
                }
            }
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(2); // 4 is the scene for CATCH
        Time.timeScale = 1.0f;
    }

    IEnumerator WaitBeforeUnloadingHealthDecrease()
    {
        yield return new WaitForSeconds(1);
        _gameController.decrementPlayerHealth();
        // NOTE: INDEX VARIES BETWEEN GAMES.
        _gameController.gameIsLoaded = false;
        SceneManager.UnloadSceneAsync(4);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        // NOTE: INDEX VARIES BETWEEN GAMES.
        _gameController.gameIsLoaded = false;
        SceneManager.UnloadSceneAsync(4);
    }
}
