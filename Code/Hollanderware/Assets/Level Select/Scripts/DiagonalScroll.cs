using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalScroll : MonoBehaviour
{
    public float speed = 5f;
    public float clamppos;
    private Vector3 startpos;


    void Start()
    {
        startpos = transform.position;
    }

    void Update()
    {
        float newpos = Mathf.Repeat(Time.time * speed, clamppos);
		transform.position = startpos + Vector3.left * newpos + Vector3.down * newpos;
    }
}
