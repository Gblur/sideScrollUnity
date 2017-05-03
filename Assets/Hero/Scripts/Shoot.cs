using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public ParticleSystem particleLauncher;
    // Use this for initialization
    void Start () {
        particleLauncher.Emit(0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            
            particleLauncher.Emit(1);
        }
    }
}
