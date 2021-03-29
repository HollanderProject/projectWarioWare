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

namespace mainController {
    public class CollectionGameController : MonoBehaviour
    {
        public bool displayDamageAnimation = false;
        public bool displayScoreAnimation = false;
        public bool collectionWin = false;
        public bool collectionLost = false;
        public int playerScore; 
        public int playerHealth;
        public static int minGamesWon = 10;
        public bool gameIsLoaded;
        private int gameToBeLoaded;

        RandomGameSelector numberGenerator;
        CollectionGameLoader gameLoader;
        AnimationsDirector aniDirector;
        GameObject CollectionScreen;
        GameObject exitButton;
        public Text scoreText;
        public Text microgameName;

        public SpriteRenderer renderedTitle;
        public Sprite[] titlesArray;

        float counter = 0;
        

        // Keep this Object ALIVEEEEE!
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        // Collection #1 has started
        void Start()
        {
            microgameName.enabled = false;
            minGamesWon = 10;
            initalizeStartOfCollection();
            CollectionScreen = GameObject.Find("CollectionScreen");
            numberGenerator = gameObject.GetComponent<RandomGameSelector>();
            gameLoader = gameObject.GetComponent<CollectionGameLoader>();
            aniDirector = gameObject.GetComponent<AnimationsDirector>();
            scoreText.text = "Lets go!";
        }

        void Update()
        {
            //if (playerScore >= 11)
            //{
            //    collectionWin = true;
            //}

            if (playerHealth <= 0)
            {
                collectionLost = true;
            }

            if (collectionWin && !collectionLost)
            {
                CollectionScreen.SetActive(true);
                aniDirector.playCollectionVictoryAnimation();
                scoreText.text = "YOU WIN!";
            }

            else if (collectionLost && !collectionWin)
            {
                CollectionScreen.SetActive(true);
                aniDirector.playCollectionLoseAnimation();
                aniDirector.SlimeIdle.enabled = false;
                scoreText.text = "GAME OVER. SCORE: " + playerScore;
            }

            else if (displayScoreAnimation)
            {
                CollectionScreen.SetActive(true);
                aniDirector.playSlimeHappyAnimation();
            }

            else if (displayDamageAnimation)
            {
                CollectionScreen.SetActive(true);
                aniDirector.playSlimeDamagedAnimation();
            }

            // If non of these conditions are met, load another game.
            else if (!gameIsLoaded)
            {
                gameIsLoaded = true;
                StartCoroutine(WaitThenLoad());
            }
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
                return 3; // BROWSE
            else if (num == 1)
                return 4; // CATCH
            else if (num == 2)
                return 5; // CLIMB
            else if (num == 3)
                return 6; // CONNECT
            else if (num == 4)
                return 7; // CUT
            else if (num == 5)
                return 8; // HERD
            else if (num == 6)
                return 9; // ORGANIZE
            else if (num == 7)
                return 10; // POKE
            else if (num == 8)
                return 11; // SHOOT
            else if (num == 9)
                return 12; // NUDGE
            else // Aka it returns 10
                return 13; // SPOT
        }

        void OnGUI()
        {   
            if (collectionWin || collectionLost)
            {
                if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 50, 100, 100), "Main Menu"))
                {
                    SceneManager.LoadScene(1);
                    SceneManager.UnloadSceneAsync(15);
                    Destroy(this.gameObject);
                }
            }
        }

        void displayGameName(int gameIndex)
        {
            microgameName.enabled = true;
            if (gameIndex == 3)
                microgameName.text = "BROWSE!";
            else if (gameIndex == 4)
                microgameName.text = "CATCH!";
            else if (gameIndex == 5)
                microgameName.text = "CLIMB!";
            else if (gameIndex == 6)
                microgameName.text = "CONNECT!";
            else if (gameIndex == 7)
                microgameName.text = "CUT!";
            else if (gameIndex == 8)
                microgameName.text = "HERD!";
            else if (gameIndex == 9)
                microgameName.text = "ORGANIZE!";
            else if (gameIndex == 10)
                microgameName.text = "POKE!";
            else if (gameIndex == 11)
                microgameName.text = "SHOOT!";
            else if (gameIndex == 12)
                microgameName.text = "NUDGE!";
            else
                microgameName.text = "SPOT!";
        }

        void initalizeThenLoad()
        {
            gameToBeLoaded = numberGenerator.PsuedoRandomGameSelection();
            loadSplash(gameToBeLoaded);
            // Unload title?????
            renderedTitle.sprite = titlesArray[4];
            gameToBeLoaded = actualGame(gameToBeLoaded);
            displayGameName(gameToBeLoaded);
            gameLoader.loadGame(gameToBeLoaded);
            CollectionScreen.SetActive(false);
            StartCoroutine(WaitToRemoveText(1.5f));
            //microgameName.enabled = false;
        }

        IEnumerator WaitThenLoad()
        {
            yield return new WaitForSeconds(2.5f);
            initalizeThenLoad();
        }

        IEnumerator WaitToRemoveText(float time)
        {
            yield return new WaitForSeconds(time);
            microgameName.enabled = false;
        }

        // Expected to be called by microgame's manager
        public void decrementPlayerHealth()
        {
            microgameName.enabled = false;
            Debug.Log("Player has taken damage");
            playerHealth -= 1;

            displayDamageAnimation = true;
            scoreText.text = "SCORE: " + playerScore;
        }

        // Expected to be called by microgame's manager
        public void incrementPlayerScore()
        {
            microgameName.enabled = false;
            Debug.Log("Player has score");
            playerScore += 1;

            displayScoreAnimation = true;
            scoreText.text = "SCORE: " + playerScore;
        }

    }
}