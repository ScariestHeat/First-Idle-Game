using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AngelBuying : MonoBehaviour {

	public SoulClick click;
	public UnityEngine.UI.Text iteminfo;
	public int cost;
	public int count = 0;
	public float clickPower;
	public string itemName;
	private float baseCost;

	void Start()
	{
		baseCost = cost;
	}

	void Update()
	{
		iteminfo.text = itemName + "\nCost: " + cost + "  Power: +" + clickPower;
	}

	public void PurchasedUpgrade(){
		if(click.Souls >= cost) {
			click.Souls -= cost;
			count += 1;
			click.soulsperclick += clickPower;
			cost = Mathf.RoundToInt (baseCost * Mathf.Pow (1.15f, count));
		}
	}







	/*
	public void PurchasedUpgrade(){
		if(click.Souls >= cost) {
			click.Souls -= cost;
			count += 1;
			click.soulsperclick += clickpower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}
*/
}
