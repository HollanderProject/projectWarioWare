using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCursor : MonoBehaviour
{
    private TrailRenderer trail;
    // Start is called before the first frame update
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = position;

        if (Input.GetMouseButtonDown(0))
        {
            trail.startColor = Color.red;
            trail.endColor = Color.red;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            trail.startColor = Color.yellow;
            trail.endColor = Color.yellow;
        }
     
    }
}
