using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlacement : MonoBehaviour
{
    private bool done = false;
    private bool lastMovement = true; // true == up, false == down

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (lastMovement == true)
        {
            transform.localScale.y -= .01f;
            lastMovement = false;
        }
        else
        {
            transform.localScale.y += .01f;
            lastMovement = true;
        }*/

        if (done == false)
        {
            transform.position = new Vector2(transform.position.x, PointPositions.startPointPositionY + .3f);
            done = true;
        }
    }
}
