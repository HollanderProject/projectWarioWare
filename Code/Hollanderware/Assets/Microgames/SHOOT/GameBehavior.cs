using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{

    public bool canPlayerShoot = false;
    private bool showWinScreen = false;
    private bool showLoseScreen = false;
    private bool stopCounting = false;

    public int minDraw = 1;
    public int maxDraw = 3;
    public float drawWindow = 0.65f;
    public float timeRemaining = 5;

    private float randomDrawTime;
    private float drawWindowWithRandomTime;

    // Sprite changes <- make this into a seperate class later.
    SpriteRenderer fireSpeachBubble;
    SpriteRenderer youWinSpeachBubble;
    SpriteRenderer youLoseSpeachBubble;
    SpriteRenderer shotRender;
    SpriteRenderer neutralRender;
    SpriteRenderer attackRender;
    SpriteRenderer hitRender;
    SpriteRenderer eyeRender;

    GameObject neutralStance;
    GameObject attackStance;

    AudioSource gunSound;

    void Awake()
    {
        randomDrawTime = Random.Range(minDraw,maxDraw);
        drawWindowWithRandomTime = randomDrawTime - drawWindow;
        Debug.Log("Random Number is: " + randomDrawTime);
        Debug.Log("You lose the draw if don't fire before: " + drawWindowWithRandomTime);

        fireSpeachBubble = GameObject.Find("WildGun_Fire").GetComponent<SpriteRenderer>();
        youWinSpeachBubble = GameObject.Find("WildGun_YouWin").GetComponent<SpriteRenderer>();
        youLoseSpeachBubble = GameObject.Find("WildGun_YouLose").GetComponent<SpriteRenderer>();
        neutralRender = GameObject.Find("CowboyNeutral").GetComponent<SpriteRenderer>();
        attackRender = GameObject.Find("CowboyFire").GetComponent<SpriteRenderer>();
        hitRender = GameObject.Find("CowboyHitAnimation").GetComponent<SpriteRenderer>();
        shotRender = GameObject.Find("ShotAnimation").GetComponent<SpriteRenderer>();
        neutralStance = GameObject.Find("CowboyNeutral");
        attackStance = GameObject.Find("CowboyFire");

        gunSound = GameObject.Find("GunSound").GetComponent<AudioSource>();
    }

    void Update()
    {
        // Basic countdown
        if (timeRemaining > 0)
        {
            if (timeRemaining < randomDrawTime)
            {
                Debug.Log("SHOOT!");
                canPlayerShoot = true;
            }
            timeRemaining -= Time.deltaTime;
        }

        if (canPlayerShoot)
        {
            displayFireAnimation();
        }

        // Shot too early
        if (Input.GetMouseButtonDown(0) && !canPlayerShoot && !showWinScreen)
        {
            displayHitAnimation(false);
            Debug.Log("You shot too early!");
            showLoseScreen = true;
            stopCounting = true;
        }

        // Shot at the right time
        if (Input.GetMouseButtonDown(0) && canPlayerShoot && !showLoseScreen)
        {
            displayHitAnimation(true);
            Debug.Log("You got him!");
            showWinScreen = true;
            stopCounting = true;
        }

        // Shot too late
        if (timeRemaining < drawWindowWithRandomTime && !stopCounting)
        {
            displayShotAnimation();
            Debug.Log("You were too late!");
            showLoseScreen = true;
            stopCounting = true;
        }

    }

    // Swaps sprites out to display "Fire" prompt and shooting sprite.
    void displayFireAnimation()
    {
        fireSpeachBubble.enabled = true;
        neutralRender.enabled = false;
        attackRender.enabled = true;
    }

    void displayShotAnimation()
    {
        gunSound.Play();
        fireSpeachBubble.enabled = false;
        neutralStance.SetActive(false);
        shotRender.enabled = true;
        youLoseSpeachBubble.enabled = true;
    }

    void displayHitAnimation(bool hitRightTime)
    {
        gunSound.Play();
        neutralStance.SetActive(false);
        attackStance.SetActive(false);
        hitRender.enabled = true;
        if (hitRightTime)
            youWinSpeachBubble.enabled = true;
        else
            youLoseSpeachBubble.enabled = true;
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }

     void OnGUI()
    {
        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 50, 200, 100), "Level Select"))
            {
                RestartLevel();
            }
        }
        
        if (showLoseScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 -50, 200, 100), "Level Select"))
            {
                RestartLevel();
            }
        }
    }
}
