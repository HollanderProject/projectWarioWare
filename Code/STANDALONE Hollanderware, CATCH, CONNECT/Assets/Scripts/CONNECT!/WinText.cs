using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    public static SpriteRenderer winText;
    public float opacity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        winText = GetComponent<SpriteRenderer>();
        winText.color = new Color(1f, 1f, 1f, opacity);
    }

    public static void MakeVisible()
    {
        winText.color = new Color(1f, 1f, 1f, 1f);
    }
}
