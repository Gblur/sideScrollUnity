using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    
    public AnimationCurve xCurve;
	public Enemy enemy;
    public Enemy otherEnemy;
	private Enemy[] enemies;
    public float Yrange = .5f;
    public int EnemySpeed = 5;
    // Use this for initialization
    
        
    

    void Start () {


		enemies = new Enemy[3];
		for (int i = 0; i < enemies.Length; i++) {
			Enemy clone = Instantiate (
				enemy, 
				new Vector2(27,i * 8), 
				transform.rotation
			);
			enemies [i] = clone;
		}
	}


	// Update is called once per frame
	void Update () {

        float YPos = xCurve.Evaluate(Time.time) * Yrange;
       

        // @todo kill objects if they're out of the canvas
        foreach (Enemy enemy in enemies) {
            enemy.move(new Vector2(-1 * Time.deltaTime * EnemySpeed , YPos));
                
                }
	}
}
