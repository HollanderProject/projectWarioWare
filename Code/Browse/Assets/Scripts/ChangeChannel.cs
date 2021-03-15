using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


// Manages TV stuff
public class ChangeChannel : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] channelsArray;
    public VideoPlayer winVideo;
    public Transform videoPosition;
    public int currentChannel = 0; // start at channel 1, consider randomizing.
    public int winChannel;
    public float minStayOnChannel = 2f;
    private float curHoldTime = 0f;
    public bool isPlayerOnRightChannel;
    GameManagerBrowse _gameManager;

    void Start()
    {
        winVideo = GameObject.Find("Funni Win Screen").GetComponent<VideoPlayer>();
        videoPosition = GameObject.Find("Funni Win Screen").GetComponent<Transform>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBrowse>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        curHoldTime = minStayOnChannel;
        ActuallyChangeChannel(currentChannel);
        winVideo.enabled = false;
        RandomizeWinChannel();
        Debug.Log("The random channel is: " + (winChannel+1));
    }

    // Expected calls: 60 per second.
    void Update()
    {
        // Right Click -> +1
        if (Input.GetMouseButtonDown(1))
        {
            ChangeChannelNumber(1);
        }
        
        // Left Click -> -1
        else if  (Input.GetMouseButtonDown(0))
        {
            ChangeChannelNumber(-1);
        }

        // Player is on the correct channel
        if (currentChannel == winChannel)
        {
            isPlayerOnRightChannel = true;

            if (winVideo.enabled == false)
                enableVideo();
            else
                returnVideoToOriginalPosition();
                
            curHoldTime -= 1 * Time.deltaTime;

            if (curHoldTime <= 0)
            {
                curHoldTime = 0;
                _gameManager.setPlayerWinToTrue();
            }
        }

        // Player has moved off the right channel, reset counter.
        if (isPlayerOnRightChannel && (currentChannel != winChannel))
        {
            isPlayerOnRightChannel = false;
            moveVideoOffScreen();
            Debug.Log("You've moved off the right channel!");
            curHoldTime = minStayOnChannel;
        }

    }

    void ChangeChannelNumber(int channelChange)
    {
        currentChannel += channelChange;

        // Wrap around
        if (currentChannel < 0)
            currentChannel = 8;
        else if (currentChannel > 8)
            currentChannel = 0;

        ActuallyChangeChannel(currentChannel);
    }

    void ActuallyChangeChannel(int newChannel)
    {
        spriteRenderer.sprite = channelsArray[currentChannel];
    }

    void enableVideo()
    {
        winVideo.enabled = true;
        returnVideoToOriginalPosition();
    }
    
    void moveVideoOffScreen()
    {
        winVideo.Pause();
        videoPosition.position = new Vector3(3.9f, 13.6f, 1);
    }

    void returnVideoToOriginalPosition()
    {
        winVideo.Play();
        videoPosition.position = new Vector3(3.9f, 13.6f, -4);
    }

    public void RandomizeWinChannel()
    {
        winChannel = Random.Range(5,8);
    }

}
