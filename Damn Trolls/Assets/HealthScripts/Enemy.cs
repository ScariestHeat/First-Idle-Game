using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int MaxHealth = 100;
	public GameObject DamageEffect;
	public int Health {get; private set;}

	public void Awake()
	{
		Health = MaxHealth;
	}


	public void TakeDamage(int damage)
	{
		Instantiate(DamageEffect, transform.position, transform.rotation);
		Health -= damage;
	}
}
