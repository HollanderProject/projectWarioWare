using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimerHERD : MonoBehaviour
{
    public SpriteRenderer currentFrame;
    public Sprite[] batteryFrames; // NOTE: Set array animation in reverse.
    public GameObject winText;

    public float startingTime = 10f;
    public float currentTime = 0f;

    private bool keepCounting = true;

    void Start()
    {
        currentFrame = gameObject.GetComponent<SpriteRenderer>();
        currentTime = startingTime;
    }

    void Update()
    {
        if (keepCounting)
        {
            currentTime -= 1 * Time.deltaTime;
            changeBatteryFrame(currentTime);
        }

        if (currentTime <= 0)
        {
            keepCounting = false;
        }
    }

    public void changeBatteryFrame(float index)
    {
        int roundedIndex = (int)Mathf.Ceil(index);
        if (roundedIndex <= 9)
            currentFrame.sprite = batteryFrames[roundedIndex];
    }


}