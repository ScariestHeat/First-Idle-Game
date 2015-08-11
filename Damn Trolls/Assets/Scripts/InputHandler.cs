using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour 
{

	void Update () 
	{
		if(Input.GetMouseButton(00))
		{
			Debug.Log ("Mouse Clicked!");
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit rayCastHit;
			if(Physics.Raycast(ray.origin, ray.direction, out rayCastHit, Mathf.Infinity))
			{
				Debug.Log ("Mouse Click!");
			}
		}
	}

}