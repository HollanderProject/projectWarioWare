using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    Canvas popup;
    DrumInteraction drumState;

    void Start()
    {
        popup = GameObject.Find("Screen_Popup").GetComponent<Canvas>();
        drumState = GameObject.Find("TaikoMain").GetComponent<DrumInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            popup.enabled = false;
            drumState.canDrum();
        }
    }
}
