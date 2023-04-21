using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 6, decreaseTime, minPipeDistance = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public bool isOn = false; //To freeze the pipes before game start;


    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
            if (spawnRate > minPipeDistance)
            {
                spawnRate -= decreaseTime;
            }
        }        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        if (isOn == true) //To check if the game has begun;
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
       
    }
}
