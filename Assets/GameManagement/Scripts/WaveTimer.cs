using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveTimer : MonoBehaviour {

    private Text countText;
    private int Count;

	// Use this for initialization
	void Start () {
       countText = GetComponent<Text>();
	}
    

    public void Waves() {

        
        countText.text = Time.time.ToString("0");
        //Debug.Log(Time.time);

    }

	// Update is called once per frame
	void Update () {
        Waves();

    }
}
