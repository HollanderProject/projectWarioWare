using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour
{

    public void finishedAnimation()
    {
        SpriteRenderer hitanimation = GetComponent<SpriteRenderer>();
        hitanimation.enabled = false;
    }
}
