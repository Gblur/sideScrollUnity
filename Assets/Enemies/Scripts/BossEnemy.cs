using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossEnemy : Enemy
{


    public Image healthBar;
    public float damageToHealthbar;



    public override void gotHit(int damage)
    {
        base.gotHit(damage);
       
        this.healthBar.fillAmount -= damage * 0.01f;
        


    }
}
