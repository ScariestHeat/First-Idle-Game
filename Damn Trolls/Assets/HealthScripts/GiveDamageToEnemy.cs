using UnityEngine;
using System.Collections;

public class GiveDamageToEnemy : MonoBehaviour {

	public int DamageToGive = 10;

	public void OnTriggerEnter2d(Collider2D other)
	{
		var enemy = other.GetComponent<Enemy>();
		if (enemy == null)
			return;

		enemy.TakeDamage(DamageToGive);

	}
}
