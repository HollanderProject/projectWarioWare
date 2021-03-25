using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo : MonoBehaviour
{
    public GameObject winText;
    public GameObject failText;
    public GameObject bamboo;
    public GameObject bambooSlicedPrefab;
    public float startForce = 150f;
    public Vector3 offset = new Vector3(0, 0, 0);
    Rigidbody2D rb;

    void start()
    {
        // Adding physics to the bamboo, and setting initially win/fail text states
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        winText.SetActive(false);
        failText.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // When the blade collides with the bamboo, remove the bamboo and instantiate the bambooSlicedPrefab
        if (collision.tag == "Scissors")
        {
            Vector3 direction = (collision.transform.position - transform.position.normalized);
            Quaternion rotation = Quaternion.LookRotation(direction);
            Instantiate(bambooSlicedPrefab, direction, transform.rotation);
            Destroy(this.gameObject);
            Debug.Log("Collision detected.");
        }
    }
}
