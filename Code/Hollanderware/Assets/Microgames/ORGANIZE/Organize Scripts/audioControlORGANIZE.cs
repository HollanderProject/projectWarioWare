using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControlORGANIZE : MonoBehaviour
{
    public AudioSource winJingle;
    public AudioSource failJingle;
    public GameObject check;
    public GameObject cross;
    private bool played = false;

    // Update is called once per frame
    void Update()
    {
        if(!played && check.activeSelf)
        {
            played = true;
            winJingle.Play();
        }
        else if(!played && cross.activeSelf)
        {
            played = true;
            failJingle.Play();
        }
    }
}
