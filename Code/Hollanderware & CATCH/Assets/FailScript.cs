using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailScript : MonoBehaviour
{
    public static int failGoal = 5;
    public static int failScoreValue = 0;
    Text failScore;

    // Start is called before the first frame update
    void Start()
    {
        failScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        failScore.text = "x" + failScoreValue + "/" + failGoal;
    }
}
