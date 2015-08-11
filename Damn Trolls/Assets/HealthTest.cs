using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthTest : MonoBehaviour {

	public float startingHealth = 100;
	public Scrollbar HealthBar;
	public float Health = 100;

	Animator anim;
	bool isDead;


	void Awake ()
	{
		anim = GetComponent<Animator> ();

		Health = startingHealth;
	}


	public void Damage(float value)
	{
		if(isDead)
			return;
		Health -= value;
		HealthBar.size = Health / 100f;

		if(Health <= 0)
		{
			Death ();
		}
	}

	void Death ()
	{
		isDead = true;

		anim.SetTrigger("Dead");

	}

}
