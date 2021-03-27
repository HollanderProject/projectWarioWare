using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Expected Behavior and Purpose - 
// 
// Manages player status of the collection. collectionWin or collectionLost
// Provides functions for microgame's manager to call to edit hearts/score.
// Call RandomGameSelector to prepare next game.
// Provides a status to game selectors, instead of displaying retry, to return back to collection.
//

namespace mainController {
    public class CollectionGameController : MonoBehaviour
    {
        public bool displayDamageAnimation;
        public bool displayScoreAnimation;
        public bool collectionWin = false;
        public bool collectionLost = false;
        public int playerScore; 
        public int playerHealth;
        public static int minGamesWon = 10;
        public bool gameIsLoaded;
        private int gameToBeLoaded;

        RandomGameSelector numberGenerator;
        CollectionGameLoader gameLoader;

        public SpriteRenderer renderedTitle;
        public Sprite[] titlesArray;
        

        // Keep this Object ALIVEEEEE!
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        // Collection #1 has started
        void Start()
        {
            initalizeStartOfCollection();
            numberGenerator = gameObject.GetComponent<RandomGameSelector>();
            gameLoader = gameObject.GetComponent<CollectionGameLoader>();
        }

        void Update()
        {
            if (playerScore >= 4)
            {
                collectionWin = true;
            }

            if (playerHealth <= 0)
            {
                collectionLost = true;
            }

            if (collectionWin && !collectionLost)
            {
                Debug.Log("YOU'VE WON!!");
            }

            else if (collectionLost && !collectionWin)
            {
                Debug.Log("YOU'VE LOST ;(");
                // Display Exit Button back to Level Select or Restart by recalling this scene?
            }

            // If non of these conditions are met, load another game.
            else if (!gameIsLoaded)
            {
                gameToBeLoaded = numberGenerator.PsuedoRandomGameSelection();
                loadSplash(gameToBeLoaded);
                StartCoroutine(WaitABit());
                // Unload title?????
                renderedTitle.sprite = titlesArray[4];
                gameToBeLoaded = actualGame(gameToBeLoaded);
                gameLoader.loadGame(gameToBeLoaded);
                gameIsLoaded = true;
            }

            /*
            if (Input.GetKeyDown("3"))
            {
                // Test Load. Testing is 3.
                gameLoader.loadGame(3);
            }

            if (Input.GetKeyDown("4"))
            {
                gameLoader.loadGame(12);
            }

            if (Input.GetKeyDown("5"))
            {
                gameLoader.loadGame(8);
            }

            // CUT DOES NOT WORK PROPERLY
            if (Input.GetKeyDown("6"))
            {
                gameLoader.loadGame(7);
            }

            if (Input.GetKeyDown("7"))
            {
                gameLoader.loadGame(4);
            }

            // DEBUG
            if (Input.GetKeyDown("d"))
            {
                Debug.Log("(CALLED)Current Health = " + playerHealth);
                Debug.Log("(CALLED)Current Score = " + playerScore);
                Debug.Log("(CALLED) Did Player win? " + collectionWin);
                Debug.Log("(CALLED) Did Player lose? " + collectionLost);
            }
            */
        }

        // Start of game. Call function
        void initalizeStartOfCollection()
        {
            playerScore = 0;
            playerHealth = 4;
            collectionLost = false;
            collectionWin = false;
        }

        void loadSplash(int gameNumber)
        {
            // Load Browse
            if (gameNumber == 1)
            {
                renderedTitle.sprite = titlesArray[1];
            }
            // Load Shoot
            else if (gameNumber == 0)
            {
                renderedTitle.sprite = titlesArray[0];
            }
            // load herd
            else if (gameNumber == 2)
            {
                renderedTitle.sprite = titlesArray[2];
            }
            // load catch
            else if (gameNumber == 3)
            {
                renderedTitle.sprite = titlesArray[3];
            }
        }

        int actualGame(int num)
        {
            if (num == 0)
            {
                return 3; // BROWSE
            }

            else if (num == 1)
            {
                return 12; // NUDGE
            }

            else if (num == 2)
            {
                return 8; // HERD
            }

            else if (num == 3)
            {
                return 7; // CUT
            }

            else if (num == 4)
            {
                return 4; // CATCH
            }
            else
                return 4;
        }

        void OnGUI()
        {   
            if (collectionWin || collectionLost)
            {
                if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 50, 100, 100), "Return to Home"))
                {
                    SceneManager.LoadScene(1);
                }
            }
        }

        IEnumerator WaitABit()
        {
            yield return new WaitForSeconds(3);
        }

        // Expected to be called by microgame's manager
        public void decrementPlayerHealth()
        {
            Debug.Log("Player has taken damage");
            playerHealth -= 1;

            displayDamageAnimation = true;
        }

        // Expected to be called by microgame's manager
        public void incrementPlayerScore()
        {
            Debug.Log("Player has score");
            playerScore += 1;

            displayScoreAnimation = true;
        }

    }
}