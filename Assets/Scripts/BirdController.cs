using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    Rigidbody2D bird;

    // True OR False value to check if bird is alive or not
    public bool isAlive;

    int score = 0;

    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        // Set the alive to true
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            	bird.AddForce(new Vector2(0,1) * 250);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            //Increase score by 1
            score = score + 1;

            scoreUI.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //set alive to false on Collision
        isAlive = false;
    }
}
