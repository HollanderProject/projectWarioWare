using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerCollisionForWhenLightTouchesGem : MonoBehaviour
{
    GameManagerSpot _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManagerSpot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // A function that handles collision between the mouse reticle and the gem
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger!");
        //ChangeScene("spotWinScreen");
        _gameManager.setPlayerWinToTrue();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
