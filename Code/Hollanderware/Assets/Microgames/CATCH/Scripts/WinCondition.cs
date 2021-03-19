﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    //public Text winText;
    public static bool gameActive;
    SpriteRenderer checkSprite;

    void Start()
    {
        //winText = GetComponent<Text>();
        gameActive = true;
        checkSprite = GameObject.Find("CheckSpriteCATCH").GetComponent<SpriteRenderer>();
        Debug.Log(checkSprite);
        checkSprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue >= ScoreScript.scoreGoal)
        {
            //winText.text = "You Win!";
            gameActive = false;
            GameManagerCATCH.playerWin = true;
            checkSprite.enabled = true;
            Debug.Log("Game Over: Victory");
            GraphicTimerCATCH.keepCounting = false;

        }
        //else if (FailScript.failScoreValue >= FailScript.failGoal)
        //{
        //    //winText.text = "You Lose";
        //    gameActive = false;
        //    GameManagerCATCH.playerLose = true;
        //    loseScreen.enabled = true;
        //    Debug.Log("Game Over: Out of time");
        //}
    }
}
