using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BridgeResize : MonoBehaviour
{
    public static LineRenderer lineRenderer;
    public static Vector3 mousePosition;
    private Vector2 startPosition;
    public static bool bridgeBuilt = false;
    public static Vector2 finalEndPoint;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.sortingLayerName = "Not Background";
        lineRenderer.sortingOrder = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Fix this; doesn't need to run every frame
        startPosition = new Vector2(PointPositions.startPointPositionX, PointPositions.startPointPositionY);

        if (ClickDetector.mouseDown == true && bridgeBuilt == false)
        {
            lineRenderer.SetPosition(0, new Vector3(startPosition.x, startPosition.y, 1));
            mousePosition = MousePosition.mousePosition;
            lineRenderer.SetPosition(1, new Vector3(mousePosition.x, mousePosition.y, 1));
        }
    }
}
