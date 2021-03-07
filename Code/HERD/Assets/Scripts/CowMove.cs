using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource CowMooAudio;
    public CircleCollider2D circleCollider;
    public static bool CowisHerded;
    public static float forcePower = 50f;
    public float time;
    public bool turnFlag;



    // Start is called before the first frame update
    void Start()
    {
        CowisHerded = false;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.enabled = true;
        rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((PigMove.PigisHerded == true) && !turnFlag)
        {
            UpdateCow();
        }

        if (Input.GetMouseButtonDown(0))
        {
            DisplaceCow();
        }
    }

    public void DisplaceCow()
    {
        Vector2 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.Normalize();
        rb.AddForce(dir * forcePower, ForceMode2D.Force);
    }
    public void StopCow()
    {
        CowisHerded = true;
        rb.simulated = false;
    }

    public void UpdateCow()
    {
        CowMooAudio.Play();
        rb.simulated = true;
        turnFlag = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StopCow();
        Debug.Log("Collision Detected from Cow.");
    }
}
