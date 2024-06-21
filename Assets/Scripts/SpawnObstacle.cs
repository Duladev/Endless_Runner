using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Time.time > spawnTime)
        {
            spawn();
            spawnTime= Time.time + timeBetweenSpawn;
        }
    }
    void spawn()
    {
        float randonX= Random.Range(minX, maxX);
        float randonY= Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3 (randonX,randonY, 0), transform.rotation);


    }
}
