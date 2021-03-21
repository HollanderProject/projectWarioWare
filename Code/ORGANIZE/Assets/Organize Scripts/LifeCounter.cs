using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeCounter : MonoBehaviour
{
    private bool failed = false;
    public TMP_Text lifeText;
    public GameObject cross;

    // Update is called once per frame
    void Update()
    {
        if(cross.activeSelf && !failed)
        {
            failed = true;
            lifeText.text = Convert.ToString(Int32.Parse(lifeText.GetParsedText()) - 1);
        }
    }
}
