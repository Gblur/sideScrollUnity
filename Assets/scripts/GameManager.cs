using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject enemy;
	// Use this for initialization
	void Start () {
		CreateEnemy ();
	}

	void CreateEnemy () {
		enemy.transform.Translate (Vector2.left * Time.deltaTime * 1f);
		Instantiate (enemy, transform.position, transform.rotation);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
