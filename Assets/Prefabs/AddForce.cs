﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    private float speed = 50f;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start ()


    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
  	}

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(speed, 0));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
