using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Enemy enemy;
	private Enemy[] enemies;
	// Use this for initialization
	void Start () {
		enemies = new Enemy[3];
		for (int i = 0; i < enemies.Length; i++) {
			Enemy clone = Instantiate (
				enemy, 
				new Vector2(10,i * 8), 
				transform.rotation
			);
			enemies [i] = clone;
		}
	}


	// Update is called once per frame
	void Update () {
		// @todo kill objects if they're out of the canvas
		foreach (Enemy enemy in enemies) {
			enemy.move (Vector2.left * Time.deltaTime * 5);
		}
	}
}
