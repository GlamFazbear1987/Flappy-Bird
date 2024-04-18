using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    BirdController birdScript;
    public float speed;

   void Awake()
    {
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // Move pipes left
        if(birdScript.isAlive == true)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }

    
}
