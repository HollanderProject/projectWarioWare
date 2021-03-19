using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionHERD : MonoBehaviour
{
    public GameObject winText;
    SpriteRenderer winScreen;
    int counter = 0;
    bool sheepFlag = true;
    bool pigFlag = true;
    bool cowFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        winScreen = GameObject.Find("CheckSprite").GetComponent<SpriteRenderer>();
        winScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the animal has been herded; if it has, increase the count.
        if (SheepMove.SheepisHerded == true && sheepFlag == true)
        {
            counter++;
            sheepFlag = false;
        }
        if (PigMove.PigisHerded == true && pigFlag == true)
        {
            counter++;
            pigFlag = false;
        }
        if (CowMove.CowisHerded == true && cowFlag == true)
        {
            counter++;
            cowFlag = false;
        }
        // Once all animals have been herded, show a victory and end the game.
        if (counter == 3)
        {
            GameManagerHERD.playerWin = true;
            winScreen.enabled = true;
            Debug.Log("Game end.");
            winText.SetActive(true);
            counter++;
        }
    }
}
