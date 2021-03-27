using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonInteraction : MonoBehaviour
{
    // Create variables for how the number of nose clicks the player has (zero) and the ammount they must get (ten)
    public static int noseClicks = 0;
    public static int clicksRequired = 10;
    public static bool winCheck = false;
    

    public AudioClip noseClickNoise;

    GameManagerPoke _gameManager;

    void Start ()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManagerPoke>();
    }

    void Update ()
    {   
        
    }

    // When the mouse clicks the nose 
    private void OnMouseDown()
    {
        // Increment the nose clicks for each click on the nose
        noseClicks++;

        // Play a noise to indicate the player has clicked the nose correctly
        AudioSource.PlayClipAtPoint(noseClickNoise, transform.position);
        Debug.Log("Nose click number: " + noseClicks);
        
        // Once the player has clicked the nose 10 times they are taken to the win screen
        if (noseClicks >= clicksRequired)
        {
            Debug.Log("Win condition has been met");
            _gameManager.setPlayerWinToTrue();
        }
    }
    
    // Loads the win screen and takes the player to it
    public void ChangeScene(string sceneName)
    {
        winCheck = true;
        SceneManager.LoadScene(sceneName);
    }
    
}
