using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayTVStaticSound : MonoBehaviour
{
    public AudioSource soundEffect;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) )
        {
            soundEffect.Play();
        }
    }
}