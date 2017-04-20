using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossEnemy : Enemy {

	public Image healthBar;

	public void gotHit() {
		healthBar.fillAmount -= 0.2f;
	}
}
