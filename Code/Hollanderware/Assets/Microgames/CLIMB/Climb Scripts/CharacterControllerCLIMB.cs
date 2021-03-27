using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerCLIMB : MonoBehaviour
{
  private Rigidbody2D rb;
  private Vector2 velocity;

  public SpriteRenderer spriteRenderer;
  public Sprite movingSprite1;
  public Sprite movingSprite2;
  public Sprite slidingSprite;

  private int counter = 0;

  public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // Initializes rb to be the Rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input;
        // Checks every second to see if the mousewheel isn't moving again
        if(counter % 60 == 0)
        {
            // Stops movement and swaps the sprite if the mousewheel isn't scrolling
            if(!(Input.GetAxis("Mouse ScrollWheel") > 0f))
            {
                input = new Vector2(0, 0);
                velocity = input.normalized * speed;
                spriteRenderer.sprite = slidingSprite;
            }
        }
        // Continues movement if wheel is scrolled
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            input = new Vector2(0, 1);
            velocity = input.normalized * speed;
            // Gets a random sprite for climbing based on the frame
            if(counter % 2 == 0)
            {
                spriteRenderer.sprite = movingSprite1;
            }
            else
            {
                spriteRenderer.sprite = movingSprite2;
            }
        }
        // Increments the frame counter
        counter++;
    }

    void FixedUpdate()
    {
        // Moves the Climber to the proper position
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }  
}
