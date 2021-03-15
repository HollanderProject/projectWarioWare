using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public static Vector3 mousePosition;
    public static bool active;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
        mousePosition.y = 0;
        mousePosition.x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        active = ClickDetector.mouseDown;
        if (active == true)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
        else if (active == false)
        {
            mousePosition.y = 0;
            mousePosition.x = 0;
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }
}
