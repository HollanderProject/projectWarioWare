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
    public static float forcePower = 75f;
    public float time;
    public Vector2 dir;
    bool soundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        SheepisHerded = false;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.enabled = true;
        rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomAnimal.sheepTurn == true)
        {
            if (soundPlayed == false)
            {
                SheepBaaAudio.Play();
                soundPlayed = true;
            }
            UpdateSheep();
        }
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
        RandomAnimal.sheepTurn = false;
        SheepisHerded = true;
        rb.simulated = false;
        turnFlag = false;
        RandomAnimal.boolean = (Random.value > 0.5f);
        if (RandomAnimal.animalCount == 1)
        {
            if (RandomAnimal.boolean)
            {
                RandomAnimal.pigTurn = true;
            }
            else
            {
                RandomAnimal.cowTurn = true;
            }
        }
        else if (RandomAnimal.animalCount == 2)
        {
            if (CowMove.CowisHerded == true && PigMove.PigisHerded == false)
                RandomAnimal.pigTurn = true;
            else if (CowMove.CowisHerded == false && PigMove.PigisHerded == true)
                RandomAnimal.cowTurn = true;
        }
    }

    // Is not called currently, but when randomization is added it will be
    public void UpdateSheep()
    {
        rb.simulated = true;
        turnFlag = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomAnimal.animalCount++;
        StopSheep();
        Debug.Log("Collision Detected from Sheep.");
    }
}
