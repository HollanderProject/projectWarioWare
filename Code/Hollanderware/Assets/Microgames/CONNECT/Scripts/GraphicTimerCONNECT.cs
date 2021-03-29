using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimerCONNECT : MonoBehaviour
{
    public SpriteRenderer currentFrame;
    public Sprite[] batteryFrames; // NOTE: Set array animation in reverse.
    //public GameObject winText;
    public static Sprite[] batteryFramesStatic;

    public float allottedTime = 6;
    public static float currentTime = 0f;

    public static bool keepCounting = true;

    void Start()
    {
        keepCounting = true;
        currentTime = 0;
        currentFrame = gameObject.GetComponent<SpriteRenderer>();
        currentTime = allottedTime;

        for (int i = 0; i < batteryFrames.Length; i++)
        {
            batteryFramesStatic[i] = batteryFrames[i];
        }
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
            WinCondition.gameActive = false;
            GameManagerCONNECT.playerLose = true;
            Debug.Log("Game Over: Out of time");
        }
    }

    public void changeBatteryFrame(float index)
    {
        int roundedIndex = (int)Mathf.Ceil(index);
        if (roundedIndex <= 6)
            currentFrame.sprite = batteryFrames[roundedIndex];
    }

    public float GetAllottedTime()
    {
        return allottedTime;
    }

    public float GetArrayLength()
    {
        return batteryFrames.Length;
    }


}