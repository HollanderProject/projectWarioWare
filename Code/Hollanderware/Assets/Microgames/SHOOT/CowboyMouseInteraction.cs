using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyMouseInteraction : MonoBehaviour
{
    GameBehavior _gameManager;

    void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    public void clickedOn()
    {
        if (_gameManager.canPlayerShoot)
        {
            Debug.Log("You got him!");
        }
        else
        {
            Debug.Log("You shot too early!");
        }
    }
}
