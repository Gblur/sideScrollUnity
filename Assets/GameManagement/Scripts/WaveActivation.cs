using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveActivation : MonoBehaviour {

    
    
    public int startWave;
    private ParticleSystem particles;
	// Use this for initialization
	void Start () {
        //initialize EmissionModule of ParticleSystem
        particles = GetComponent<ParticleSystem>();
        var em = particles.emission;
        em.enabled = false;
        


    }

    public void EmissionTime()
    {

      

        //Emit Particles on Time
        particles = GetComponent<ParticleSystem>();
        var em = particles.emission;
        

        if (Time.time >= startWave)
        {
            em.enabled = true;
        }
        
                


        } 
        

    
	
	// Update is called once per frame
	void Update () {
        EmissionTime();
        //Debug.Log(Time.time);
        
    }
}
