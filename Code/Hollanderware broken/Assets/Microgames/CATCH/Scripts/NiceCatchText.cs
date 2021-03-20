using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NiceCatchText : MonoBehaviour
{
    public float timeActive;
    public static bool activate;
    Text catchText;

    private AudioSource source;
    public bool play;
    public bool played = false;

    void Start()
    {
        catchText = GetComponent<Text>();
        source = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (activate == true)
        {
            catchText.text = "NICE CATCH!";
            if (played == false)
            {
                source.Play();
                played = true;
            }

            Invoke("removeText", timeActive);
        }
    }

    void removeText()
    {
        catchText.text = " ";
        activate = false;
        played = false;
    }
}
