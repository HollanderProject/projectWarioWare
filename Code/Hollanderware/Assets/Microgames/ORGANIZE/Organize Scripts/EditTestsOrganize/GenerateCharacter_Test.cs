using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class GenerateCharacter_Test : MonoBehaviour
{
    public Sprite Male;
    public Sprite Female;

    [Test]
    public void GenerateMale()
    {
        GameObject character = new GameObject("Character_1");
        character.AddComponent<SpriteRenderer>();
        var rand = new System.Random();
        int Gender = 1;

        if(Gender == 1)
        {
            character.GetComponent<SpriteRenderer>().sprite = Male;
        }
        else
        {
            character.GetComponent<SpriteRenderer>().sprite = Female;
        }

        Assert.IsTrue(character.GetComponent<SpriteRenderer>().sprite == Male);
    }
    
    [Test]
    public void GenerateFemale()
    {
        GameObject character = new GameObject("Character_1");
        character.AddComponent<SpriteRenderer>();
        var rand = new System.Random();
        int Gender = 0;

        if(Gender == 1)
        {
            character.GetComponent<SpriteRenderer>().sprite = Male;
        }
        else
        {
            character.GetComponent<SpriteRenderer>().sprite = Female;
        }

        Assert.IsTrue(character.GetComponent<SpriteRenderer>().sprite == Male);
    }

}
