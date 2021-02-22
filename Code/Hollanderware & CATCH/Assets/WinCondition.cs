using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    Text winText;

    void Start()
    {
        winText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue >= ScoreScript.scoreGoal)
        {
            winText.text = "You Win!";
        }
        else if (FailScript.failScoreValue >= FailScript.failGoal)
        {
            winText.text = "You Lose";
        }
    }
}
