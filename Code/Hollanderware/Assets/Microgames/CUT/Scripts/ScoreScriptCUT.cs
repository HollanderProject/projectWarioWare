using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScriptCUT : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Cuts: " + scoreValue + " / 5";
        if (scoreValue == 1)
        {
            score.color = new Color(1f, 0.3f, 0f, 1f);
        }

        if (scoreValue == 2)
        {
            score.color = new Color(1f, 1f, 0f, 1f);
        }

        if (scoreValue == 3)
        {
            score.color = new Color(0.2f, 0.5f, 0.9f, 1f);
        }

        if (scoreValue == 4)
        {
            score.color = new Color(0f, 0.6f, 0.1f, 1f);
        }

        if (scoreValue == 5)
        {
            score.color = new Color(0f, 1f, 0.2f, 1f);
        }
    }
}
