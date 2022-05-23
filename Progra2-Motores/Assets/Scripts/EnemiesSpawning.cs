using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawning : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoint = new GameObject[3];
    [SerializeField] private GameObject   enemyPrefab;
    [SerializeField] private float        timeToSpawn;
                     private float        timer;
    InstantiateObjects                    instantiate;
    void Start()
    {
        instantiate = new InstantiateObjects();

        if (spawnPoint == null)
        {
//            spawnPoint = GameObject.FindObjectOfType<GameObject>();
            Debug.LogWarning("No hay spawn Point de enemigos");
        }
        timer = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 9999;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    { 
        // Crea un número al azar entre 0 y el largo del array de spanwPoint
        // Luego, instancia un enemigo en esa posición

        int randomSpawnNumber = Random.Range(0, spawnPoint.Length);
        instantiate.InstantiateObject(enemyPrefab, spawnPoint[randomSpawnNumber]);
    }
}
