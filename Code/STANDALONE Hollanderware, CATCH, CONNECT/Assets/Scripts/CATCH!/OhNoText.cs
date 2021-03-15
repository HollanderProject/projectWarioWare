using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OhNoText : MonoBehaviour
{
    public float timeActive;
    public static bool activate;
    Text ohNoText;

    private AudioSource source;
    public bool play;
    public bool played = false;

    void Start()
    {
        ohNoText = GetComponent<Text>();
        source = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (activate == true)
        {
            ohNoText.text = "OH NO!";
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
        ohNoText.text = " ";
        activate = false;
        played = false;
    }
}
