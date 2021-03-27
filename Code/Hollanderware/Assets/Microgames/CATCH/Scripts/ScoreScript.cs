using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreGoal = 10;
    public static int scoreValue = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        scoreGoal = 10;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Dogs Caught: " + scoreValue + "/" + scoreGoal;
    }
}
