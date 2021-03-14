using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStatusSound : MonoBehaviour
{
    void playSound()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
    }

}
