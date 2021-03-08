using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject Arm;
    public GameObject Glass;
    public GameObject winText;
    public GameObject failText;
    public GameObject gameText;
    public BoxCollider2D BackHitbox;
    public BoxCollider2D GlassBox;

    private bool pokable = true;
    private int nudgeCount = 0;
    private float time = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 0)
        {
            if(!failText.activeSelf && !winText.activeSelf)
            {
                float pos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                Arm.transform.position = new Vector2(pos, -0.522f);
            }
            if(nudgeCount >= 4)
            {
                Win();
            }
            if(winText.activeSelf)
            {
                Glass.transform.position += new Vector3(0, -0.5f , 0);
            }
        }
        else
        {
            time -= Time.deltaTime;
        }

    }

    private void Nudge()
    {
        Glass.transform.position += new Vector3(1f, 0, 0);
        nudgeCount++;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HIT DETECTED");
        if(other == GlassBox)
        {
            Nudge();
        }
        else
        {

        }
    }

    private void Win()
    {
        gameText.SetActive(false);
        winText.SetActive(true);
    }
}
