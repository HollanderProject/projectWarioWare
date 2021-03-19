﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimerCATCH : MonoBehaviour
{
    public SpriteRenderer currentFrame;
    public Sprite[] batteryFrames; // NOTE: Set array animation in reverse.
    public GameObject winText;

    SpriteRenderer loseScreen;

    public float allottedTime;
    public float currentTime = 0f;

    public static bool keepCounting = true;

    void Start()
    {
        currentFrame = gameObject.GetComponent<SpriteRenderer>();
        currentTime = allottedTime;

        loseScreen = GameObject.Find("CrossSpriteCATCH").GetComponent<SpriteRenderer>();
        loseScreen.enabled = false;
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
            loseScreen.enabled = true;
            Debug.Log("Game Over: Out of time");
        }
    }

    public void changeBatteryFrame(float index)
    {
        int roundedIndex = (int)Mathf.Ceil(index);
        if (roundedIndex <= 9)
            currentFrame.sprite = batteryFrames[roundedIndex];
    }


}