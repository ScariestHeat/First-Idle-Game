using UnityEngine;
using System.Collections;

public class TrollSmack : MonoBehaviour {

	Animator anim;


	void Start ()
	{
		anim = GetComponent<Animator>();
	}


	void Update ()
	{
		bool hit = Input.GetMouseButtonDown(0);
		anim.SetBool("DamageTaken", hit);
		Debug.Log("Clicked");
	}

}
