using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class WinLose : MonoBehaviour
{
    public GameObject check;
    public GameObject cross;
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
        Debug.Log("build index: " + SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        if(check.activeSelf)
        {
            Win();
        }
        if(cross.activeSelf)
        {
            Lose();
        }
    }

    void OnGUI()
    {
        if (!CollectionScene.isLoaded)
        {
            if (cross.activeSelf || check.activeSelf)
            {
                Debug.Log("here2");
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

    private void Win()
    {
        if (CollectionScene.isLoaded && _gameController != null)
        {
            StartCoroutine(WaitBeforeUnloadingScoreIncrement());
        }
    }

    private void Lose()
    {
        if (CollectionScene.isLoaded && _gameController != null)
        {
            StartCoroutine(WaitBeforeUnloadingHealthDecrease());
        }
    }

    IEnumerator WaitBeforeUnloadingHealthDecrease()
    {
        yield return new WaitForSeconds(1);
        _gameController.decrementPlayerHealth();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(5);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(5);
    }
}
