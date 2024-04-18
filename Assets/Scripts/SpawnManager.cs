using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    float minimumHeight = 0.25f;
    float maximumHeight = 5.35f;

    BirdController birdScript;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 1.5f);
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(birdScript.isAlive == false)
        {
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(20.5f, Random.Range(minimumHeight, maximumHeight)), Quaternion.identity);
    }

}
