using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Startup : MonoBehaviour
{
    public GameObject cross;
    public GameObject check;
    public GameObject organizeText;
    public Sprite Male;
    public Sprite Female;
    public GameObject[] CharacterList;
    private int i = 0;
    private float fScale = 0.85f;
    private float moveSpeed = 15;
    private int k = 0;
    private bool moving = false;

    private Vector3[] StartPos = new Vector3[3]{
        new Vector3(-0.14f, -0.09f, -1f), 
        new Vector3(-0.19f, 2.25f, -0.9f), 
        new Vector3(-0.21f, 3.82f, -0.8f)
        };

    private Vector3[] FemalePos = new Vector3[3]{
        new Vector3(9.63f, -2.6f, -1f), 
        new Vector3(7.48f, -2.48f, -1f), 
        new Vector3(5.28f, -2.43f, -1f)
        };

    private Vector3[] MalePos = new Vector3[3]{
        new Vector3(-9.03f, -2.43f, -1f), 
        new Vector3(-7.08f, -2.33f, -1f), 
        new Vector3(-4.81f, -2.45f, -1f)
        };


    // Start is called before the first frame update
    void Start()
    {
        var rand = new System.Random();
        cross.SetActive(false);
        check.SetActive(false);
        int Gender;
        CharacterList = new GameObject[3];
        for(i = 0; i < 3; i++)
        {
            Gender = rand.Next() % 2;
            CharacterList[i] = GenerateCharacters(i, Gender);
            CharacterList[i].transform.position = StartPos[i];
        }
        i = 0;
    }

    private GameObject GenerateCharacters(int i, int Gender)
    {
        GameObject character = new GameObject("Character_" + i);
        character.AddComponent<SpriteRenderer>();

        if(Gender == 1)
        {
            character.GetComponent<SpriteRenderer>().sprite = Male;
        }
        else
        {
            character.GetComponent<SpriteRenderer>().sprite = Female;
            character.transform.localScale = new Vector3(fScale, fScale, fScale);
        }
        return character;
    }

    // Update is called once per frame
    void Update()
    {
        if(i <= 3 && !cross.activeSelf && !check.activeSelf && !moving)
        {
            //Left Click
            if(Input.GetMouseButtonDown(0))
            {
                if(CharacterList[i].GetComponent<SpriteRenderer>().sprite == Male)
                {
                    moving = true;
                    k = 1;
                    i++;
                }
                else
                {
                    moving = true;
                    k = 2;
                    Lose();
                }
            }
            //Right Click
            else if(Input.GetMouseButtonDown(1))
            {
                if(CharacterList[i].GetComponent<SpriteRenderer>().sprite == Female)
                {
                    moving = true;
                    k = 2;
                    i++;
                }
                else
                {
                    moving = true;
                    k = 1;
                    Lose();
                }
            }
            if(i == 3)
            {
                organizeText.SetActive(false);
                check.SetActive(true);
            }
        }
        if(moving)
        {
            if(k == 1)
            {
                Vector3 directionToMove = MalePos[i - 1] - CharacterList[i - 1].transform.position;
                directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
                float maxDistance = Vector3.Distance(CharacterList[i - 1].transform.position, MalePos[i - 1]);
                CharacterList[i - 1].transform.position = CharacterList[i - 1].transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);

                if(CharacterList[i - 1].transform.position == MalePos[i - 1])
                {
                    moving = false;
                    k = 0;
                }
            }
            if(k == 2)
            {
                Vector3 directionToMove = FemalePos[i - 1] - CharacterList[i - 1].transform.position;
                directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
                float maxDistance = Vector3.Distance(CharacterList[i - 1].transform.position, FemalePos[i - 1]);
                CharacterList[i - 1].transform.position = CharacterList[i - 1].transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);

                if(CharacterList[i - 1].transform.position == FemalePos[i - 1])
                {
                    moving = false;
                    k = 0;
                }
            }
            
        }

    }
    void Lose()
    {
        cross.SetActive(true);
    }

}
