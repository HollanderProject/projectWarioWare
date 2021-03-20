using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeCounterORGANIZE : MonoBehaviour
{
    private bool failed = false;
    public TMP_Text lifeText;
    public GameObject failText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(failText.activeSelf && !failed)
        {
            failed = true;
            lifeText.text = Convert.ToString(Int32.Parse(lifeText.GetParsedText()) - 1);
        }
    }
}
