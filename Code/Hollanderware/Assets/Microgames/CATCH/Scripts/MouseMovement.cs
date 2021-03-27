using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public static Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        mousePosition = new Vector3(0, 0, 0);
        mousePosition.y = yPosition;
        mousePosition.x = 0;
        transform.position = new Vector2(0, mousePosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        if (WinCondition.gameActive == true)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.y = yPosition;
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }
}
