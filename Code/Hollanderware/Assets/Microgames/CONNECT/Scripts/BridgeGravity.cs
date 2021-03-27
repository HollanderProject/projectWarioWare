using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeGravity : MonoBehaviour
{
    public static Rigidbody2D rb;
    public static bool fallWhenDoneDrawing = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
        fallWhenDoneDrawing = false;
    }

    public static void enableGravity()
    {
        if (fallWhenDoneDrawing == true)
        {
            rb.simulated = true;
        }
    }
}
