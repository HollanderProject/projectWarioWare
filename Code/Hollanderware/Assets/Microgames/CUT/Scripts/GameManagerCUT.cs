using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class GameManagerCUT : MonoBehaviour
{
    public bool playerWin = false;
    public bool playerLose = false;

    mainController.CollectionGameController _gameController;
    Scene CollectionScene;

    void Start()
    {
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
            if (playerWin || playerLose)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100), "Level Select"))
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
    public void setPlayerWinToTrue()
    {
        playerWin = true;
        Debug.Log("Setting win");
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
        SceneManager.UnloadSceneAsync(7);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(7);
    }
}
