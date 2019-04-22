using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    float timeBtwSpawn;

    public GameObject[] Enemy;
    public float waitTime;
    public float decrement;
    public float minTime;

    void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, Enemy.Length);
            Instantiate(Enemy[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = waitTime;
            if(waitTime >= minTime)
                waitTime -= decrement;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
