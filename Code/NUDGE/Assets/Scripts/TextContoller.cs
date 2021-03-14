using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextContoller : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject failText;
    public GameObject winText;
    public GameObject gameText;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        gameText.SetActive(true);
        winText.SetActive(false);
        failText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0 && !winText.activeSelf && !failText.activeSelf)
        {
            // Counts down time and displays it
            time -= Time.deltaTime;
            timerText.text = ((int)time).ToString();
        }
        else if(time <= 0 && !winText.activeSelf)
        {
            // Creates a failure state if time hits 0
            failText.SetActive(true);
        }
        if(time < 5 && gameText.activeSelf)
        {
            gameText.SetActive(false);
        }
        if(time < 3)
        {
            timerText.color = new Color32(250, 50, 50, 255);
        }
    }

    
}
