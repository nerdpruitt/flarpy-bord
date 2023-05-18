using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public float frequency;
    public GameObject mountain;
    public bool isOn;
    float timeBtwCloud;
    int zpos, ypos;
    // Start is called before the first frame update
    void Start()
    {
        zpos = Random.Range(5, 20);
        ypos = Random.Range(-5, 5);

    }

    // Update is called once per frame
    void Update()
    {
        timeBtwCloud -= Time.deltaTime;
        SpawnMountain();
    }
    public void SpawnMountain()
    {
        if (timeBtwCloud <= 0 && isOn == true)
        {
            Instantiate(mountain, new Vector3(transform.position.x, transform.position.y + ypos, zpos), transform.rotation);
            zpos = Random.Range(5, 20);
            ypos = Random.Range(-5, 5);
            timeBtwCloud = Random.Range(1, frequency);
        }

    }
}
