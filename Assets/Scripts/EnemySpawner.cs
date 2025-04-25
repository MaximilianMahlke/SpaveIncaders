using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private float timer = 0.2f;
    public GameObject asteroidPrefab;

    void Start()
    {

    }

    void SpawnAsteroid()
    {
            // Spawn asteroid
            Vector3 spawnPosition = new Vector3(Random.Range(-14, 14), 9, 0);
            Instantiate(asteroidPrefab, spawnPosition, asteroidPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerFinished() && !GameManager.instance.gameOver)
        {
            SpawnAsteroid();
            //SpawnAsteroid();
            //SpawnAsteroid();
        }
    }

    bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 2;
            return true;
        }
        else
        {
            return false;
        }
    }

}
