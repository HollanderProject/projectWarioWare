using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    public AudioSource winJingle;
    public AudioSource failJingle;
    public AudioSource crash;
    public GameObject check;
    public GameObject cross;
    private bool played = false;

    void Update()
    {
        if(!played && check.activeSelf)
        {
            played = true;
            winJingle.Play();
            crash.Play();
        }
        else if(!played && cross.activeSelf)
        {
            played = true;
            failJingle.Play();
        }
    }
}
