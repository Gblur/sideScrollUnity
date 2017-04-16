using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHitReaction : MonoBehaviour {

    public float repeatRate = 2;
    public float CountZero;
//    public GameObject Blob;
	private SpriteRenderer sRender;

	private void Start() {
		sRender = GetComponent<SpriteRenderer> ();
	}

	void ColorSwitch()
    {
	    if (sRender.material.color == Color.white)
	    {
	        sRender.material.color = Color.red;
	    }
	    else
	    {
	        sRender.material.color = Color.white;
	    }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
		Debug.Log ("collide");
        if (collision.gameObject.tag == "Bullet")
        {
            InvokeRepeating("ColorSwitch", 0, repeatRate);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
		Debug.Log ("collide");
        CancelInvoke();
        sRender.material.color = Color.white;

    }

	void OnParticleCollision(GameObject other) {
		Debug.Log (other);
		
	}
}
