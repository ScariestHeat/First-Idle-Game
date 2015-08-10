using UnityEngine;
using System.Collections;

public class SoulClick : MonoBehaviour {

	public UnityEngine.UI.Text spc;
	public UnityEngine.UI.Text SoulDisplayText;
	public float Souls = 0;
	public float soulsperclick = 1;

	void Update(){
		SoulDisplayText.text = "Souls: " + CurrencyConverter.Instance.GetCurrencyIntoString(Mathf.Round(Souls), false, false);	
		spc.text = CurrencyConverter.Instance.GetCurrencyIntoString(soulsperclick, false, true);
	}


	public void Clicked()
	{
		Souls += soulsperclick;
	}
}