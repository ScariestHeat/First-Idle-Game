using UnityEngine;
using System.Collections;

public class HitAnimation : MonoBehaviour {

	public bool animation_bool;
	
	void Update()
	{
		
		if(animation_bool == true)
		{
			GetComponent<Animation>().Play("TrollDamageTaken");
			
		}
		
		
		if(Input.GetMouseButtonDown(0))
		{
			animation_bool = true;
			
		}
		
		
		
	}
}