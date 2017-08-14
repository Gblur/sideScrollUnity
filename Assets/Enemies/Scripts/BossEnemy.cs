using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossEnemy : Enemy
{


    public Image healthBar;
    public float damageToHealthbar;
    public float Divider;

  

    public override void gotHit(int damage)
    {
        base.gotHit(damage);
        damageToHealthbar = damage / Divider;

        this.healthBar.fillAmount -= damageToHealthbar;
        


    }
}
