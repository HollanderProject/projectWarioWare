using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    Text winText;
    public static bool gameActive;

    void Start()
    {
        winText = GetComponent<Text>();
        gameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue >= ScoreScript.scoreGoal)
        {
            winText.text = "You Win!";
            gameActive = false;

        }
        else if (FailScript.failScoreValue >= FailScript.failGoal)
        {
            winText.text = "You Lose";
            gameActive = false;
        }
    }
}
