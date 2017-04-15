using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitReaction : MonoBehaviour {

    public float repeatRate;
    public float CountZero;
    public GameObject Blob;
        
	
	
	void ColorSwitch()
    {

        
        
            SpriteRenderer sRender = GetComponent<SpriteRenderer>();



            if (sRender.material.color == Color.white)
            {

                sRender.material.color = Color.red;
            }
            else
            {

                sRender.material.color = Color.white;

            }
        }

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            InvokeRepeating("ColorSwitch", 0, repeatRate);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SpriteRenderer sRender = GetComponent<SpriteRenderer>();
        CancelInvoke();
        sRender.material.color = Color.white;

    }


}
