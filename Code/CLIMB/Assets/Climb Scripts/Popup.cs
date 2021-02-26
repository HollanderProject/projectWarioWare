using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{   
    public GameObject myText;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Begins with the command text displaying
        myText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Stops displaying the command after 3 seconds
        if(counter == 180)
        {
            myText.SetActive(false);
        }
        // Increments the frame counter if under 3 seconds
        if(counter < 180)
        {
            counter++;
        }

    }
}
