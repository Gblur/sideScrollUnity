using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    
    public float speed;
    public GameObject bullet;
    public GameObject launchpoint;
    private GameObject instanciatedGo;
    public Vector3 direction;

	// Use this for initialization
	void Start () {
        // Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
    }


    public void OnMouseDown()
    {
        instanciatedGo = Instantiate(bullet, launchpoint.transform.position, bullet.transform.rotation);
        Debug.Log("Hello");
    }

    
    private void Update()
    {

        //instanciatedGo.transform.Translate(direction * Time.deltaTime * speed);

    }
		
}
