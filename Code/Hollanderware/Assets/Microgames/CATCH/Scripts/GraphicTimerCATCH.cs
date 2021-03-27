using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimerCATCH : MonoBehaviour
{
    public SpriteRenderer currentFrame;
    public Sprite[] batteryFrames; // NOTE: Set array animation in reverse.
    public GameObject winText;
    public static Sprite[] batteryFramesStatic;

    public float allottedTime = 16;
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

        if (currentTime <= 0 || winText.activeSelf)
        {
            keepCounting = false;
            WinCondition.gameActive = false;
            GameManagerCATCH.playerLose = true;
            Debug.Log("Game Over: Out of time");
        }
    }

    public void changeBatteryFrame(float index)
    {
        int roundedIndex = (int)Mathf.Ceil(index);
        if (roundedIndex <= 9)
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