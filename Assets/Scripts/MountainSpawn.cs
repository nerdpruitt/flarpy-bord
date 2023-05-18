using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainSpawn : MonoBehaviour
{
    public float frequency;
    public GameObject mountain;
    public bool isOn;
    float timeBtwMount;
    int zpos;
    // Start is called before the first frame update
    void Start()
    {
        zpos = Random.Range(5, 15);
    }

    // Update is called once per frame
    void Update()
    {
        timeBtwMount -= Time.deltaTime;
        SpawnMountain();
    }
    public void SpawnMountain()
    {
        if (timeBtwMount <= 0 && isOn == true)
        {
            Instantiate(mountain, new Vector3(transform.position.x, transform.position.y, zpos), transform.rotation);
            zpos = Random.Range(5, 20);
            timeBtwMount = Random.Range(1, frequency);
        }

    }
}
