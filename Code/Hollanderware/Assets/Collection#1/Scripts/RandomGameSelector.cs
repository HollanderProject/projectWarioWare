using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGameSelector : MonoBehaviour
{
    // Controls sprite popup and sends number to GameController
    public SpriteRenderer renderedTitle;
    public Sprite[] titlesArray;
    private static List<int> gameHistory = new List<int>(10);
    int randomGame;
    int actualGame;

    public int PsuedoRandomGameSelection()
    {   
        // Empty List, Reset!
        if (gameHistory.Count == 0)
        {
            ResetList();
        }

        randomGame = Random.Range(0, gameHistory.Count);
        actualGame = gameHistory[randomGame];
        gameHistory.RemoveAt(randomGame);

        return actualGame;
    }

    void updateSplashScreen(int spriteIndex)
    {
        Debug.Log("Updating to.... " + spriteIndex);
        renderedTitle.sprite = titlesArray[spriteIndex];
    }

    void ResetList()
    {
        Debug.Log("Resetting List...");
        gameHistory.Clear();
        for (int i = 0; i < 5; i++)
        {
            gameHistory.Add(i);
        }
    }

}
