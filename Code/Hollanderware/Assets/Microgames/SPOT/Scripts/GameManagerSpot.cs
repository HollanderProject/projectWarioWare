using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerSpot : MonoBehaviour
{
    public bool playerWin = false;
    public bool playerLose = false;

    SpriteRenderer winScreen;
    SpriteRenderer loseScreen;
    GameObject searchGem;

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
        searchGem = GameObject.Find("searchGem(Clone)");
        CollectionScene = SceneManager.GetSceneByBuildIndex(15);
    }

    void Update()
    {
        if (playerWin && !playerLose)
        {
            winScreen.enabled = true;
            Debug.Log("Sprite shall appear");
            if (CollectionScene.isLoaded)
            {
                Destroy(searchGem);
                StartCoroutine(WaitBeforeUnloadingScoreIncrement());
            }
        }

        if (playerLose && !playerWin)
        {
            loseScreen.enabled = true;
            Debug.Log("Sprite shall appear");
            if (CollectionScene.isLoaded)
            {
                Destroy(searchGem);
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
        _gameController.displayDamageAnimation = true;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(13);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        _gameController.gameIsLoaded = false;
        _gameController.displayScoreAnimation = true;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(13);
    }
}
