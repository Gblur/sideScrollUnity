using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public void Test()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
