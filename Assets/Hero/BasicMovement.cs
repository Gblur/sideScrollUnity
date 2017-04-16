using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

	private Vector2 moveUp;
	public int movementSpeed = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float move = movementSpeed * Time.deltaTime;

		if (Input.GetKey (KeyCode.D)) {
//			Debug.Log ("up");
			transform.Translate (Vector2.right * move);
		}
	
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.left * move);
		}
				
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * move);
		}
			
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.down * move);
		}
	}
}
