using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public float yPosition;

    // Start is called before the first frame update
    void Start()
    {
        mousePosition.y = yPosition;
        mousePosition.x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.y = yPosition;
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
