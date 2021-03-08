using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public static bool mouseDown;

    void Start()
    {
        mouseDown = false;
    }

    void OnMouseDown()
    {
        //Debug.Log("Mouse pressed");
        mouseDown = true;
    }

    void OnMouseUp()
    {
        //Debug.Log("Mouse released");
        mouseDown = false;
        BridgeResize.bridgeBuilt = true;
    }
}
