using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mainController;

public class AnimationsDirector : MonoBehaviour
{
    public SpriteRenderer SlimeIdle;
    SpriteRenderer SlimeHappy;
    SpriteRenderer SlimeDamaged;
    SpriteRenderer SlimeDefeated;
    SpriteRenderer SlimeVictory;
    SpriteRenderer EnemyIdle;
    SpriteRenderer EnemyDamaged;
    public GameObject Heart1Spr;
    SpriteRenderer Heart1;
    SpriteRenderer Heart2;
    SpriteRenderer Heart3;
    SpriteRenderer Heart4;

    bool heart1Rendered = true;
    bool heart2Rendered = true;
    bool heart3Rendered = true;
    bool heart4Rendered = true;

    mainController.CollectionGameController _gameController;

    // Initialize actors
    void Start()
    {
        _gameController = GameObject.Find("CollectionGameController").GetComponent<mainController.CollectionGameController>();
        SlimeIdle = GameObject.Find("Slime_Idle").GetComponent<SpriteRenderer>();
        SlimeHappy = GameObject.Find("Slime_Happy").GetComponent<SpriteRenderer>();
        SlimeDamaged = GameObject.Find("Slime_Damaged").GetComponent<SpriteRenderer>();
        SlimeDefeated = GameObject.Find("Slime_Defeated").GetComponent<SpriteRenderer>();
        SlimeVictory = GameObject.Find("Slime_Victory").GetComponent<SpriteRenderer>();
        EnemyIdle = GameObject.Find("Enemy_Slime_Idle").GetComponent<SpriteRenderer>();
        EnemyDamaged = GameObject.Find("Enemy_Slime_Damaged").GetComponent<SpriteRenderer>();

        //Heart1 = GameObject.Find("Heart1").GetComponent<SpriteRenderer>();
        Heart1 = gameObject.GetComponent<SpriteRenderer>();
        Heart2 = GameObject.Find("Heart2").GetComponent<SpriteRenderer>();
        Heart3 = GameObject.Find("Heart3").GetComponent<SpriteRenderer>();
        Heart4 = GameObject.Find("Heart4").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (_gameController.playerHealth <= 0)
            Heart1Spr.SetActive(false);
    }

    public void playIdleAnimations()
    {
        SlimeIdle.enabled = true;
        EnemyIdle.enabled = true;
        SlimeHappy.enabled = false;
        SlimeDamaged.enabled = false;
        EnemyDamaged.enabled = false;
        StartCoroutine(AnimationDelay());
    }

    public void playSlimeHappyAnimation()
    {
        _gameController.displayScoreAnimation = false;
        SlimeIdle.enabled = false;
        SlimeHappy.enabled = true;
        EnemyIdle.enabled = false;
        EnemyDamaged.enabled = true;
        StartCoroutine(AnimationDelay());
    }

    public void playSlimeDamagedAnimation()
    {
        _gameController.displayDamageAnimation = false;
        SlimeIdle.enabled = false;
        EnemyIdle.enabled = true;
        SlimeDamaged.enabled = true;
        takeDamageAnimation();
        StartCoroutine(AnimationDelay());
    }

    public void playCollectionVictoryAnimation()
    {
        SlimeIdle.enabled = false;
        EnemyIdle.enabled = false;
        SlimeVictory.enabled = true;
        EnemyDamaged.enabled = true;
    }

    public void playCollectionLoseAnimation()
    {
        SlimeIdle.enabled = false;
        EnemyIdle.enabled = true;
        SlimeDefeated.enabled = true;
        StartCoroutine(LoseDelay());
    }

    public void takeDamageAnimation()
    {
        if (heart4Rendered)
        {
            heart4Rendered = false;
            Heart4.enabled = false;
        }
        else if (heart3Rendered)
        {
            heart3Rendered = false;
            Heart3.enabled = false;
        }
        else if (heart2Rendered)
        {
            heart2Rendered = false;
            Heart2.enabled = false;
        }
        else if (heart1Rendered)
        {
            heart1Rendered = false;
            Heart1.enabled = false;
        }
    }

    IEnumerator LoseDelay()
    {
        yield return new WaitForSeconds(3.0f);
    }

    IEnumerator AnimationDelay()
    {
        yield return new WaitForSeconds(1.5f);
        playIdleAnimations();
    }
}
