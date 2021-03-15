using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngineNoise : MonoBehaviour
{
    private AudioSource source;
    public bool play;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (play == true)
        {
            source.Play();
            play = false;
        }
    }
}
