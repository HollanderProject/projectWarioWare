using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource SheepBaaAudio;
    public CircleCollider2D circleCollider;
    public static bool SheepisHerded;
    public bool turnFlag = false;
    public static float forcePower = 50f;
    public float time;
    public Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        SheepisHerded = false;
        SheepBaaAudio.Play();
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplaceSheep();
        }
    }

    public void DisplaceSheep()
    {
        Vector2 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.Normalize();
        rb.AddForce(dir * forcePower, ForceMode2D.Force);
    }

    public void StopSheep()
    {
        SheepisHerded = true;
        rb.simulated = false;
    }

    // Is not called currently, but when randomization is added it will be
    public void UpdateSheep()
    {
        SheepBaaAudio.Play();
        rb.simulated = true;
        turnFlag = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StopSheep();
        Debug.Log("Collision Detected from Sheep.");
    }
}
