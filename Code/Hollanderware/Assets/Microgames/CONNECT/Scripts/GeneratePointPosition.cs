using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePointPosition : MonoBehaviour
{
    public GameObject circle;

    public float xMinDistance;
    public float xMaxDistance;
    public float yMinDistance;
    public float yMaxDistance;
    public bool startPoint; // True = point is the start point, False = point is the end point

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(xMinDistance, xMaxDistance);
        float y = Random.Range(yMinDistance, yMaxDistance);
        transform.position = new Vector2(x, y);
        Debug.Log(circle.name + ": (" + x + ", " + y + ")");

        if (startPoint == true)
        {
            PointPositions.startPointPositionX = x;
            PointPositions.startPointPositionY = y;
        }
        else
        {
            PointPositions.endPointPositionX = x;
            PointPositions.endPointPositionY = y;
        }
    }
}
