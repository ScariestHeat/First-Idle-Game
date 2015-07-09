using UnityEngine;
using System.Collections;

public class SoulClick : MonoBehaviour {

	public UnityEngine.UI.Text SoulDisplayText;
	public float Souls = 0.00f;
	public int soulsperclick = 1;

	void Update(){
		SoulDisplayText.text = "Souls: " + Souls;
	}

	public void Clicked(){
		Souls += soulsperclick;
	}

}
