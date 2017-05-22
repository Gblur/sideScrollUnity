using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFlow : MonoBehaviour {

    public GameObject[] displayArray;
    public Vector2 uvOffset = Vector2.zero;
    public Vector2 uvAnimSpeed = new Vector2(0f, .5f);
    public float endTime;
    public Renderer rend;

    void Start()
    {
        displayArray = GameObject.FindGameObjectsWithTag("Displays");
        StartCoroutine(TextSlider());
        rend = GetComponent<Renderer>();
    }

    IEnumerator TextSlider()
    {
        yield return new WaitForSeconds(1);
        foreach (GameObject Displays in displayArray)
        {
            while (uvOffset.y < endTime)
            {

                uvOffset += (uvAnimSpeed * Time.deltaTime);
                rend.material.SetTextureOffset("_MainTex", uvOffset);
                

                yield return null;

            }
        }
    }


}
