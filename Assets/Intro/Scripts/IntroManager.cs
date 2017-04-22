using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

	public Scene firstScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onStartClick () {
		Debug.Log ("start");
		SceneManager.LoadScene("Scenes/FirstScene", LoadSceneMode.Single);
	}
}
