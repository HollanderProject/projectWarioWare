using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseText : MonoBehaviour
{
    public static SpriteRenderer loseText;
    public float opacity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        loseText = GetComponent<SpriteRenderer>();
        loseText.color = new Color(1f, 1f, 1f, opacity);
    }

    public static void MakeVisible()
    {
        loseText.color = new Color(1f, 1f, 1f, 1f);
    }
}
