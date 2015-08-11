using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrollSmack : MonoBehaviour {




	public void OnClick()
	{
		GameObject TrollDamageTaken = GameObject.Find ("Troll");
		Animator anim = TrollDamageTaken.GetComponent<Animator>();
		anim.SetTrigger("DamageTaken");

		//anim.ResetTrigger("DamageTaken 0");
	}











	//	void Start ()
//	{
//		anim = GetComponent<Animator>();
//	}
//
//
//	void Update ()
//	{
//		anim.SetTrigger("DamageTaken");
//		Debug.Log("Clicked");
//	}
//
//
//}
}