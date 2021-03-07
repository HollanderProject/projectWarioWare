using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    void playSound()
    {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play();
    }
}
