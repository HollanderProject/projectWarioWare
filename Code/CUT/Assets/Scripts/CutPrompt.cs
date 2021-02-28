using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutPrompt : MonoBehaviour
{
    public GameObject cutPrompt;
    // Start is called before the first frame update
    void Start()
    {
        cutPrompt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 1)
        {
            cutPrompt.SetActive(false);
        }
    }
}
