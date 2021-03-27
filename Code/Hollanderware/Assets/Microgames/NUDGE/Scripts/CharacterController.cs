using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using mainController;

public class CharacterController : MonoBehaviour
{
    public GameObject Arm;
    public GameObject Glass;
    public GameObject check;
    public GameObject cross;
    public GameObject gameText;
    public BoxCollider2D BackHitbox;
    public BoxCollider2D GlassBox;
    mainController.CollectionGameController _gameController;
    Scene CollectionScene;

    private bool pokable = true;
    private int nudgeCount = 0;
    private float time = 0.25f;

    void Start()
    {
        _gameController = GameObject.Find("CollectionGameController").GetComponent<mainController.CollectionGameController>();
        CollectionScene = SceneManager.GetActiveScene();
        Debug.Log("build index: " + CollectionScene.buildIndex);
    }
    // Update is called once per frame
    void Update()
    {
        //gives grace period of 1/4 a second so the arm doesnt move immediately
        if(time < 0)
        {
            if(!cross.activeSelf && !check.activeSelf)
            {
                float pos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                Arm.transform.position = new Vector2(pos, -1.05f);
            }
            if(nudgeCount >= 4)
            {
                Win();
            }
            if(check.activeSelf)
            {
                Glass.transform.position += new Vector3(0, -0.5f , 0);
            }
            if(cross.activeSelf)
            {
                Lose();
            }
        }
        else
        {
            time -= Time.deltaTime;
        }

    }

    private void Nudge()
    {
        Glass.transform.position += new Vector3(1f, 0, 0);
        nudgeCount++;
        pokable = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == GlassBox)
        {
            if(pokable)
                Nudge();
        }
        else
        {  
            if(!pokable)
            {
                pokable = true;
                other.transform.Translate(Vector3.right);
            }
        }
    }

    private void Win()
    {
        gameText.SetActive(false);
        check.SetActive(true);
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
