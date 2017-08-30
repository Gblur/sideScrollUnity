using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausefunction : MonoBehaviour {

    public CanvasGroup SubMenuA;
    public CanvasGroup MainMenuA;
    // Use this for initialization
    void Start () {
        SubMenuA = GetComponent<CanvasGroup>();
        MainMenuA = GetComponent<CanvasGroup>();
    }

    public void OnMouseclickPause()
    {
            Time.timeScale = 0;
    }


    public void OnMouseclicktart()
    {

        Time.timeScale = 1;

    }
    // Update is called once per frame
    void Update () {
        
        }
}
