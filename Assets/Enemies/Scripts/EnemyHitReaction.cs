using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHitReaction : MonoBehaviour {

    

	public GameObject explosion;
	private GameObject explosionInstance;
	private float explosionDeltaTime;

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
//		Debug.Log (other.tag);

		if (other.tag == "Bullet")
		{
			// Create the flickering if the object collides.
			now = Time.time;
			delta = now + 0.2F;
			InvokeRepeating ("ColorSwitch", 0, 0.01F);

			// If explosion is set create an instance of explosion 
			// and start animation for a lifetime.
			if (explosion) {
				this.explosionDeltaTime = now + explosion.GetComponent<ParticleSystem> ().startLifetime;
				this.explosionInstance = Instantiate (
					explosion, 
					this.gameObject.transform.position, 
					this.gameObject.transform.rotation
				);
			}
		}	
	}

    void Update(){
		
		if (delta > 0 && Time.time > delta) {
			CancelInvoke ();
			sRender.material.color = Color.white;
		}

		if (explosionDeltaTime > 0 && Time.time > explosionDeltaTime) {
			Destroy (explosionInstance);
		}
       
	}

	void OnDestroy () {
		// cleanup
		CancelInvoke ();
		Destroy (explosionInstance, explosion.GetComponent<ParticleSystem> ().startLifetime);
	}
}
