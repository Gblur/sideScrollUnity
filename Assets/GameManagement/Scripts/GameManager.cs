using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public Enemy enemy;
    public Vector2 spawnValues;
    public Enemy otherEnemy;
    private Enemy[] enemies;
    public int EnemySpeed = 5;
    public float spawnWait = 5.0f;
    public float startWait;
    public float WaveWait;
    public float space = -47;
    // Use this for initialization




    void Start()
    {
        
        StartCoroutine(SpawnWaves());

    }

    public IEnumerator SpawnWaves()
    {


        yield return new WaitForSeconds(startWait);
        while(Time.time < 20)
        {
            enemies = new Enemy[25];
            for (int i = 0; i < enemies.Length; i++)
            {
                Vector2 YSpace = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
                Enemy clone = Instantiate(
                    enemy,
                    YSpace,
                    transform.rotation
                );

                enemies[i] = clone;
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(WaveWait);
        }

    }


    // Update is called once per frame
    void Update()
    {
		
		// @todo kill objects if they're out of the canvas
        foreach (Enemy enemy in enemies) {
			
            enemy.move (Vector2.left * Time.deltaTime * 5);
        }
    }
}

        