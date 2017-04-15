using UnityEngine;
using System.Collections;

public class TurretShot : MonoBehaviour {


	Animator animator;


	private Transform target;
	public int movementSpeed;
	public int rotatationSpeed;


	public float rotateSpeed;
	private bool targeted = false;
	public bool door = false;
	private int currentPoint;

	void Start () 
	{
		target = GameObject.Find("hammerboy").transform;

		animator = GetComponent<Animator>();



	}

	void Update () 
	{



		if(targeted == false)
		{

			animator.SetBool("door",false);  
		}

		if(Vector3.Distance(transform.position, target.position) < 3)
		{
			targeted = true;
		}
		else if(Vector3.Distance(transform.position, target.position) > 8)
		{
			targeted = false;
		}

		if(targeted == true)
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotateSpeed * Time.deltaTime);

			animator.SetBool("door",true);         

		} } } 
