using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class WinLose : MonoBehaviour
{
    public GameObject check;
    public GameObject cross;
    public GameObject climber;
    public GameObject victoryPose;
    public BoxCollider2D failBox;
    public BoxCollider2D winBox;
    mainController.CollectionGameController _gameController;
    Scene CollectionScene;

    void Start()
    {
        _gameController = GameObject.Find("CollectionGameController").GetComponent<mainController.CollectionGameController>();
        CollectionScene = SceneManager.GetActiveScene();
        // Hides the win text and victory pose
        check.SetActive(false);
        cross.SetActive(false);
        victoryPose.SetActive(false);
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Logs the hit and then stops the game, causing the win text and victory pose to occur
        Debug.Log("HIT DETECTED");
        climber.GetComponent<Rigidbody2D>().gravityScale = 0;
        climber.SetActive(false);
        if(other == winBox)
        {
            check.SetActive(true);
            victoryPose.SetActive(true); 
        }
        else if(other == failBox)
        {
            cross.SetActive(true);
        }
        
    }

    private void Win()
    {
        if (CollectionScene.isLoaded)
        {
            StartCoroutine(WaitBeforeUnloadingScoreIncrement());
        }
    }

    private void Lose()
    {
        if (CollectionScene.isLoaded)
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
        SceneManager.UnloadSceneAsync(12);
    }

    IEnumerator WaitBeforeUnloadingScoreIncrement()
    {

        yield return new WaitForSeconds(1);
        _gameController.incrementPlayerScore();
        _gameController.gameIsLoaded = false;
        // NOTE: INDEX VARIES BETWEEN GAMES.
        SceneManager.UnloadSceneAsync(12);
    }
}
