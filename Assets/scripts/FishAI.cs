using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAI : MonoBehaviour {

    public float acceleration; 
	public int hitpoints;

	// Use this for initialization
	void Start () {

	}

    private void FixedUpdate()
    {
        transform.position = new Vector3(0f,(Mathf.PingPong(Time.time * acceleration, 13)),0.25f);                
    }

    // Update is called once per frame
    void Update () {
		
	}
}
