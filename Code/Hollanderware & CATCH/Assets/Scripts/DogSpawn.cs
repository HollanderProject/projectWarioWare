using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawn : MonoBehaviour
{
    public float delay = .5f;
    public GameObject Dog;
    public int count = 0;

    void Spawn()
    {
        Instantiate(Dog, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(count);
        if (collision.collider.name != "Floor" && OhNoText.activate == false)
        {
            ScoreScript.scoreValue += 1;
            if (ScoreScript.scoreValue <= ScoreScript.scoreGoal - 1)
            {
                NiceCatchText.activate = true;
            }
        }
        else if (collision.collider.name == "Floor" && NiceCatchText.activate == false)
        {
            FailScript.failScoreValue += 1;
            if (FailScript.failScoreValue <= FailScript.failGoal - 1)
            {
                OhNoText.activate = true;
            }
            
        }

        if (count == 0 && ScoreScript.scoreValue < ScoreScript.scoreGoal && FailScript.failScoreValue < FailScript.failGoal)
        {
            Spawn();
            gameObject.active = false;
            count = 1;
        }
        else if (count == 1 && ScoreScript.scoreValue < ScoreScript.scoreGoal && FailScript.failScoreValue < FailScript.failGoal)
        {
            gameObject.active = false;
            Spawn();
        }
        else
        {
            gameObject.active = false;
        }
    }
}
