using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointCollisionDetection : MonoBehaviour
{
    // TODO
    // Make it use the endpoint of the bridge as the way to calculate a win or loss,
    // rather than where the user's mouse last was. 

    public static Vector3 finalMousePos;
    public static float finalMousePosX;
    public static float finalMousePosY;
    public static float xPosDiff;
    public static float yPosDiff;
    private float buffer = .075f;

    // Update is called once per frame
    void Update()
    {
        if (BridgeResize.bridgeBuilt == true)
        {
            BridgeResize.finalEndPoint = BridgeResize.lineRenderer.GetPosition(1);
            //Debug.Log(BridgeResize.finalEndPoint);

            finalMousePos = BridgeResize.finalEndPoint;
            finalMousePosX = finalMousePos.x;
            finalMousePosY = finalMousePos.y;

            xPosDiff = Mathf.Abs(PointPositions.endPointPositionX - finalMousePosX);
            yPosDiff = Mathf.Abs(PointPositions.endPointPositionY - finalMousePosY);

            if (xPosDiff <= buffer && yPosDiff <= buffer)
            {
                //Debug.Log("Win");
                WinText.MakeVisible();
                //Application.Quit();
            }
            else
            {
                //Debug.Log("Lose");
                LoseText.MakeVisible();
                //Application.Quit();
            }

            BridgeGravity.enableGravity();
        }
    }
}
