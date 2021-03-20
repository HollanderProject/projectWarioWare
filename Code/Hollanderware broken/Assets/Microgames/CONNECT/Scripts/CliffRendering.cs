using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliffRendering : MonoBehaviour
{
    private SpriteRenderer sprite;
    public float spriteWidth;
    public float spriteHeight;
    public bool leftCliff = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        spriteWidth = sprite.sprite.rect.width;
        spriteHeight = sprite.sprite.rect.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftCliff == true)
        {
            float x = PointPositions.startPointPositionX;
            float y = PointPositions.startPointPositionY;
            transform.position = new Vector2(x, y);
        }
        else
        {
            float x = PointPositions.endPointPositionX;
            float y = PointPositions.endPointPositionY;
            transform.position = new Vector2(x, y);
        }
    }
}
