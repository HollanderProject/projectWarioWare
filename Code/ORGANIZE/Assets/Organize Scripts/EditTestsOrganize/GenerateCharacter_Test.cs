using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class GenerateCharacter_Test : MonoBehaviour
{
    public Sprite Male;
    public Sprite Female;

    [Test]
    public void NoTimeLosing()
    {
        GameObject character = new GameObject("Character_1");
        character.AddComponent<SpriteRenderer>();
        var rand = new System.Random();
        int Gender = rand.Next() % 2;

        if(Gender == 1)
        {
            character.GetComponent<SpriteRenderer>().sprite = Male;
        }
        else
        {
            character.GetComponent<SpriteRenderer>().sprite = Female;
        }

        if(Gender == 1)
        {
            Assert.IsTrue(character.GetComponent<SpriteRenderer>().sprite == Male);
        }
        else
        {
            Assert.IsTrue(character.GetComponent<SpriteRenderer>().sprite == Female);
        }
    }

}
