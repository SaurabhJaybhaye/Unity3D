using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwnmanager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject catcherPrefab;
    public Vector2 spawnRangeX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEvader), 0, 1.0f);
        InvokeRepeating(nameof(SpawnCatcher), 2.0f, 3.0f);
    }

    private void SpawnCatcher()
    {
        SpawnEnemy(EnemyType.Catcher);
    }

    private void SpawnEvader()
    {
        SpawnEnemy(EnemyType.Evader);
    }

    // Update is called once per frame
    private void SpawnEnemy(EnemyType enemyType)
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRangeX[0], spawnRangeX[1]),
            enemyPrefab.transform.position.y,
            enemyPrefab.transform.position.z
            );

        if(enemyType == EnemyType.Evader)
        {
            Instantiate(
           enemyPrefab,
           spawnPosition,
           enemyPrefab.transform.rotation);
        }
        else
        {
            Instantiate(
           catcherPrefab,
           spawnPosition,
           catcherPrefab.transform.rotation);
        }
    }

    
}
