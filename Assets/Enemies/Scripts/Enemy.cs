using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

//	public string name = "Foo";
	public int health = 100;
	public int attackPower;
	public int attackRate;
    public Vector2 space;


	private string state = "uninitialized";


	const string STATE_ALIVE = "alive";
	const string STATE_DEAD = "dead";


	public void Start(){
		this.name = name;
		this.setState (STATE_ALIVE);

	}
    void Space()
    {
        space = this.transform.position;
        if (this.space.x <= -47) {
            this.setState(STATE_DEAD);
                }

    }

	public virtual void gotHit(int damage) {
		this.health -= damage;
       
//		Debug.Log (health);
		if (this.health <= 0 ) {
			this.setState (STATE_DEAD);
		}		
	}

	public void setState(string state) {
		this.state = state;
		switch (state) {
		case STATE_DEAD:
			Destroy (this.gameObject);
			break;
		}
	}

    internal void move(Vector2 vector2, object p)
    {
        throw new NotImplementedException();
    }
    // Hero AttackDamage on Collision 
    void OnParticleCollision(GameObject other) {
		// Debug.Log ("Hit");
		this.gotHit(10);
	}

	public void move(Vector2 coords) {
		if (this.state != STATE_DEAD) {
			this.gameObject.transform.Translate(coords);
		}
	}
    private void Update()
    {
        Space();
    }
}
