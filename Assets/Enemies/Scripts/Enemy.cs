using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{

    //	public string name = "Foo";
    public int health = 100;
    public int attackPower;
    public int attackRate;
    public Vector2 space;
    public AnimationCurve xCurve;

    private string state = "uninitialized";
	private float born;	

    const string STATE_ALIVE = "alive";
    const string STATE_DEAD = "dead";


    public void Start()
    {
        this.name = name;
        this.setState(STATE_ALIVE);
        this.born = Time.realtimeSinceStartup;
    }
    void Space()
    {
        space = this.transform.position;
        if (this.space.x <= -47)
        {
            this.setState(STATE_DEAD);
        }

    }

    public float getLifeTime()
    {
        return Time.realtimeSinceStartup - this.born;
    }

    public virtual void gotHit(int damage)
    {
        this.health -= damage;

        //		Debug.Log (health);
        if (this.health <= 0)
        {
            this.setState(STATE_DEAD);
        }
    }

    public void setState(string state)
    {
        this.state = state;
        switch (state)
        {
            case STATE_DEAD:
                Destroy(this.gameObject);
                break;
        }
    }

    internal void move(Vector2 vector2, object p)
    {
        throw new NotImplementedException();
    }
    // Hero AttackDamage on Collision 
    void OnParticleCollision(GameObject other)
    {
        // Debug.Log ("Hit");
        this.gotHit(10);
    }

    public void move(Vector2 coords)
    {
        if (this.state != STATE_DEAD)
        {
            float Yrange = 0.2f;
			float lifeTime  = this.getLifeTime();
            float YPos = xCurve.Evaluate(lifeTime) * Yrange;
            Vector2 pos = new Vector2(coords.x, YPos);
            this.gameObject.transform.Translate(pos);
        }
    }
    private void Update()
    {
        Space();
    }
}
