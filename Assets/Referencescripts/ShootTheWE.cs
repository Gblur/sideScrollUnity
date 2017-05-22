using UnityEngine;
using System.Collections;


public class ShootTheWE : MonoBehaviour {

	Animator animator;
	private Transform target;
	public int movementSpeed;
	public int rotatationSpeed;
	public Rigidbody BulletPrefab;
	public float Speed = 2;

	public float rotateSpeed;
	private bool targeted = false;
	public bool door = false;
	private int currentPoint;
	public float fireRate;
	private float nextFire;


	void Start () 
	{
		target = GameObject.FindWithTag("Player").transform;
//		InvokeRepeating("Projectile", 0.0f, 1.0f / fireRate);
	
	}

	void Update ()
	{
		if (targeted == false && target != null ) {

		
		}

		if (Vector3.Distance (transform.position, target.position) <= 30) {
			targeted = true;
		} else if (Vector3.Distance (transform.position, target.position) > 30) {
			targeted = false;
		}
	}
		
	void Projectile() {

		if(targeted == true && target != null)
		{
			Rigidbody bullet = (Rigidbody) Instantiate(BulletPrefab, transform.position, transform.rotation);
			bullet.velocity = transform.forward * Speed;

		} 
						
	} 

} 
