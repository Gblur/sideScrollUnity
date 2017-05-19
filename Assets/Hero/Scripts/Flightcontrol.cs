using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flightcontrol : MonoBehaviour {

    // Use this for initialization
    float down;
    private Animator flight;
	void Start () {
        GetComponent<Animator>();
	}
	private void fly()
    {

        down = Input.GetAxis("Vertical");
        flight.SetFloat("Down", down);

    }
	// Update is called once per frame
	void Update () {
        fly();
        Debug.Log(down);
    }
}
