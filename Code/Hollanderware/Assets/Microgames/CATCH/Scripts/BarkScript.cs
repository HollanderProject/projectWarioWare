using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarkScript : MonoBehaviour
{
    public static AudioSource source;
    public static bool enableBark = false;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public static void playBark()
    {
        enableBark = true;
        source.Play();
        enableBark = false;
    }
}
