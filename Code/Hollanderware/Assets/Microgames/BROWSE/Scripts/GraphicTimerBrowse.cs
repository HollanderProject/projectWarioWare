using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimerBrowse : MonoBehaviour
{
    public SpriteRenderer currentFrame;
    public Sprite[] batteryFrames; // NOTE: Set array animation in reverse.

    public float startingTime = 10f;
    public float currentTime = 0f;

    private bool keepCounting = true;

    GameManagerBrowse _gameManager;

    void Start()
    {
        currentFrame = gameObject.GetComponent<SpriteRenderer>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBrowse>();
        currentTime = startingTime;
    }

    void Update()
    {
        
        if (_gameManager.playerWin)
        {
            keepCounting = false;
        }
        

        if (keepCounting)
        {
            currentTime -= 1 * Time.deltaTime;
            changeBatteryFrame(currentTime);
        }

        if (currentTime <= 0)
        {
            _gameManager.setPlayerLoseTrue();
            keepCounting = false;
        }
    }

    void changeBatteryFrame(float index)
    {
        int roundedIndex = (int)Mathf.Ceil(index);
        currentFrame.sprite = batteryFrames[roundedIndex];
    }


}
