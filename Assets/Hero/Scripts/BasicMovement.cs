using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

	
	public int movementSpeed = 100;
    public Animator moveAnim;
    private float axisX;
    private float axisY;

    // Use this for initialization
    void Start () {
        moveAnim = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {

		float move = movementSpeed * Time.deltaTime;
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");


        if (axisX > 0f)
        {
//			Debug.Log ("up");
			transform.Translate (Vector2.right * move);
		}
	
		if (axisX < 0f)
        {
			transform.Translate (Vector2.left * move);
		}
				
		if (axisY > 0f) {
		    transform.Translate (Vector2.up * move);
            moveAnim.SetFloat("Ymove", axisY);
            
		}
			
		if (axisY < 0f) {
			transform.Translate (Vector2.down * move);
            moveAnim.SetFloat("Ymove", axisY);

        


           // Debug.Log(axisY);
		}
	}
}
