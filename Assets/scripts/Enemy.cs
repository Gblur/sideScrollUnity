using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

//	public string name = "Foo";
	public int health = 100;
	public int attackPower;
	public int attackRate;

	private string state = "uninitialized";

	const string STATE_ALIVE = "alive";
	const string STATE_DEAD = "dead";


	public void Start(){
		this.name = name;
		this.setState (STATE_ALIVE);

	}

	public void gotHit(int damage) {
		this.health -= damage;
		Debug.Log (health);
		if (this.health < 0) {
			Destroy (this.gameObject);
			this.setState (STATE_DEAD);		
		}		
	}

	private void setState(string state) {
		this.state = state;
		switch (state) {
		case STATE_DEAD:
			

			break;
		}
	}

	void OnParticleCollision(GameObject other) {
		Debug.Log ("Treffer");
		this.gotHit (50);
	}

	public void move(Vector2 coords) {
		if (this.state != STATE_DEAD) {
			this.gameObject.transform.Translate (coords);
		}
	}
}
