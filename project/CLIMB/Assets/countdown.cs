using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class countdown : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject failText;
    public GameObject winText;
    public GameObject climber;
    public float time;

    // Update is called once per frame
    void Update()
    {
        if(time > 0 && !winText.activeSelf)
        {
            // Counts down time and displays it
            time -= Time.deltaTime;
            timerText.text = ((int)time).ToString();
        }
        else if(time <= 0 && !winText.activeSelf)
        {
            // Creates a failure state if time hits 0
            failText.SetActive(true);
            climber.GetComponent<Rigidbody2D>().gravityScale = 0;
            climber.SetActive(false);
        }
    }
    
}
