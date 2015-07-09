using UnityEngine;
using System.Collections;

public class AngelBuying : MonoBehaviour {

	public SoulClick click;
	public UnityEngine.UI.Text iteminfo;
	public float cost;
	public float count = 0;
	public int clickPower;
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
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
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
