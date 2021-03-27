using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource CowMooAudio;
    public CircleCollider2D circleCollider;
    public static bool CowisHerded;
    public static float forcePower = 125f;
    public float time;
    public bool turnFlag = false;
    bool soundPlayed = false;



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
        if (RandomAnimal.cowTurn == true)
        {
            if (soundPlayed == false)
            {
                CowMooAudio.Play();
                soundPlayed = true;
            }
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
        RandomAnimal.cowTurn = false;
        CowisHerded = true;
        rb.simulated = false;
        turnFlag = false;
        RandomAnimal.boolean = (Random.value > 0.5f);
        if (RandomAnimal.animalCount == 1)
        {
            if (RandomAnimal.boolean)
            {
                RandomAnimal.sheepTurn = true;
            }
            else
            {
                RandomAnimal.pigTurn = true;
            }
        }
        else if (RandomAnimal.animalCount == 2)
        {
            if (SheepMove.SheepisHerded == true && PigMove.PigisHerded == false)
                RandomAnimal.pigTurn = true;
            else if (SheepMove.SheepisHerded == false && PigMove.PigisHerded == true)
                RandomAnimal.sheepTurn = true;
        }
    }

    public void UpdateCow()
    {
        rb.simulated = true;
        turnFlag = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomAnimal.animalCount++;
        StopCow();
        Debug.Log("Collision Detected from Cow.");
    }
}
