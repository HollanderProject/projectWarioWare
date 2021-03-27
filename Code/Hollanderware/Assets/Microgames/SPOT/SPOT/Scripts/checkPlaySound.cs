using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPlaySound : MonoBehaviour
{
    void playSound()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
        Debug.Log("Sound shall play");
    }

}