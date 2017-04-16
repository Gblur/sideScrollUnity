﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHitReaction : MonoBehaviour {

    public float repeatRate = 2;
    public float CountZero;
//    public GameObject Blob;
	private SpriteRenderer sRender;
	private float now;
	private float delta;

	private void Start() {
		sRender = GetComponent<SpriteRenderer> ();
	}

	private void ColorSwitch()
    {
		if (sRender.material.color == Color.white) {
			sRender.material.color = Color.red;
		} else {
			sRender.material.color = Color.white;
		}
    }

	void OnParticleCollision(GameObject other) {
		Debug.Log (other.tag);

		if (other.tag == "Bullet")
		{
			now = Time.time;
			delta = now + 0.2F;
			InvokeRepeating ("ColorSwitch", 0, 0.01F);
		}	
	}

	void Update(){
		
		if (delta > 0 && Time.time > delta) {
			CancelInvoke ();
			sRender.material.color = Color.white;
		}
	}
}
