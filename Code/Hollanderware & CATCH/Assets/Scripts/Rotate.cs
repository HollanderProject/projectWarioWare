using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotationSpeed;
    private float rotZ;
    public float smoothness = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotZ += -Time.deltaTime * RotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
