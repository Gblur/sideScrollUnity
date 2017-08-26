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
    public ParticleSystem enemyFireBall;
    public GameObject hero;
    private string state = "uninitialized";
	private float born;
    private bool targeted;
    public float rotateSpeed = 5;


    const string STATE_ALIVE = "alive";
    const string STATE_DEAD = "dead";


    public void Start()
    {
        this.name = name;
        this.setState(STATE_ALIVE);
        this.born = Time.realtimeSinceStartup;
        enemyFireBall.Emit(0);
        InvokeRepeating("shoot", 0, 0.5f);


    }

    void MeasureDistance()
    {
        hero = GameObject.FindGameObjectWithTag("Player");
        Vector3 HeroPosition = hero.transform.position;
        Quaternion HeroRot = hero.transform.rotation;
        float Distance = Vector2.Distance(this.transform.position, HeroPosition);


        //Get Angle between enemy and Hero and set value on enemy's Z-Axis 
        Vector3 targetDir = (transform.position - HeroPosition);
        var angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //Debug.Log(angle);
        //Debug.Log(dir);

        if (Distance < 30)

        {
            targeted = true;
        }
       
       
        
        


    }

    void shoot()
    {
        if (targeted == true && hero != null)
        {
            enemyFireBall.Emit(1);
        }


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
        MeasureDistance();
        
        
       
    }
}
