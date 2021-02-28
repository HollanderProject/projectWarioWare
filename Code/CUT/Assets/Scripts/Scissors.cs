using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour
{
    public AudioSource BladeCutAudio;
    public int count = 0;
    public float minCutVelocity = 0.1f;

    public bool isCutting = false;
    Vector2 previousPosition;

    Rigidbody2D rb;
    Camera cam;
    public CircleCollider2D circleCollider;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If Left mouse button is held down, the blade will be active
        // If Left mouse button is not held down, the blade will be inactive
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateCut();
        }
    }

    public void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        // The blade is only active if the mouse is moving over the velocity threshold.
        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCutVelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;
        }
        previousPosition = newPosition;
    }
    public void StartCutting()
    {
        isCutting = true;
        circleCollider.enabled = false;
    }

    public void StopCutting()
    {
        isCutting = false;
        circleCollider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // If the blade collides with the bamboo object, play the audio sound and update score
        if (collision.tag == "Bamboo")
        {
            BladeCutAudio.Play();
            ScoreScript.scoreValue += 1;
            count++;
            Debug.Log(count);
        }
    }
}
