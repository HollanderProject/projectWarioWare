using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumInteraction : MonoBehaviour
{
    public AudioSource drumSound;
    public SpriteRenderer spriteRenderer;
    public Sprite[] drumStates;
    static int neutral = 0,
               left = 1,
               right = 2,
               dual = 3;
    
    public float currentTime;
    public bool CanHitDrum = false;
    public bool activeState = false;
    public int framesCounted = 0;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        drumSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (CanHitDrum)
        {
            if (!activeState)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    Debug.Log("Right Click");
                    RightHit();
                }

                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Left Click");
                    LeftHit();
                }

                if (Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(1))
                {
                    Debug.Log("Dual Click");
                    DualHit();
                }
            }

            // Hold
            else if (Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(1))
            {
                // Intentionally Empty.
            }

            else
            {
                if (framesCounted <= 5)
                {
                    framesCounted++;
                }

                else if (framesCounted >= 5)
                {
                    NeutralReset();
                    framesCounted = 0;
                }
            }
        }
    }

    void RightHit()
    {
        spriteRenderer.sprite = drumStates[right];
        drumSound.Play();
        activeState = true;
    }

    void LeftHit()
    {
        spriteRenderer.sprite = drumStates[left];
        drumSound.Play();
        activeState = true;
    }

    void DualHit()
    {
        spriteRenderer.sprite = drumStates[dual];
        drumSound.Play();
        activeState = true;
    }

    void NeutralReset()
    {
        spriteRenderer.sprite = drumStates[neutral];
        activeState = false;
    }

    public void canDrum()
    {
        CanHitDrum = true;
        Debug.Log("Hits Enabled");
    }
}
