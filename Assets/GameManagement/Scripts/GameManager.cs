using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Enemy enemy;
    private Enemy[] enemies;
    public float spawnWait = 1f;
    public float startWait = 1;
    public float waveWait = 6;
    public int enemyCount = 0;
    public float speed;
    // Use this for initialization
    void Start()
    {
        // enemies = new Enemy[3];
        // for (int i = 0; i < enemies.Length; i++)
        // {
        //     Enemy clone = Instantiate(
        //         enemy,
        //         new Vector2(10, i * 8),
        //         transform.rotation
        //     );
        //     enemies[i] = clone;
        // }
        // StartCoroutine(SpawnWaves());

        enemies = new Enemy[5];
    }

    void spawnEnemies()
    {
        int timeInSeconds = (int)Time.realtimeSinceStartup;
        if (timeInSeconds > enemyCount && enemyCount < enemies.Length)
        {
            Enemy clone = Instantiate(
                enemy,
                new Vector2(37, 1 * 8),
                transform.rotation
            );
            enemies[enemyCount] = clone;
            enemyCount++;
        }
        
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                Vector2 spawnPosition = new Vector2(10, i * 1);

                Instantiate(enemy, spawnPosition, transform.rotation);
                yield return new WaitForSeconds(spawnWait);
            }

            yield return new WaitForSeconds(waveWait);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemies();

        try
        {
            // @todo kill objects if they're out of the canvas
            foreach (Enemy enemy in enemies)
            {
                enemy.move(Vector2.left * Time.deltaTime * speed);
            }
        }
        catch (System.NullReferenceException)
        {
            // throw;
        }

    }
}
