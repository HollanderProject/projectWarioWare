using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject winText;
    int counter = 0;
    bool sheepFlag = true;
    bool pigFlag = true;
    bool cowFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Game end.");
            winText.SetActive(true);
            counter++;
        }
    }
}
