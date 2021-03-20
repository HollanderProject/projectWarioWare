using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource PigOinkAudio;
    public CircleCollider2D circleCollider;
    public static bool PigisHerded;
    public static float forcePower = 75f;
    public float time;
    public bool turnFlag = false;
    bool soundPlayed = false;



    // Start is called before the first frame update
    void Start()
    {
        PigisHerded = false;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.enabled = true;
        rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomAnimal.pigTurn == true)
        {
            if (soundPlayed == false)
            {
                PigOinkAudio.Play();
                soundPlayed = true;
            }
            UpdatePig();
        }

        if (Input.GetMouseButtonDown(0))
        {
            DisplacePig();
        }
    }

    public void DisplacePig()
    {
        Vector2 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.Normalize();
        rb.AddForce(dir * forcePower, ForceMode2D.Force);
    }

    public void StopPig()
    {
        RandomAnimal.pigTurn = false;
        PigisHerded = true;
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
                RandomAnimal.cowTurn = true;
            }
        }
        else if (RandomAnimal.animalCount == 2)
        {
            if (PigMove.PigisHerded == true && CowMove.CowisHerded == false)
                RandomAnimal.cowTurn = true;
            else if (SheepMove.SheepisHerded == false && CowMove.CowisHerded == true)
                RandomAnimal.sheepTurn = true;
        }
    }

    public void UpdatePig()
    {
        rb.simulated = true;
        turnFlag = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomAnimal.animalCount++;
        StopPig();
        Debug.Log("Collision Detected from Pig.");
    }
}
