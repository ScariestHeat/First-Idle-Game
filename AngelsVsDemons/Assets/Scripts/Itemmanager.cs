using UnityEngine;
using System.Collections;

public class Itemmanager : MonoBehaviour {

	public UnityEngine.UI.Text iteminfo;
	public SoulClick click;
	public float cost;
	public int tickvalue;
	public int count;
	public string itemName;
	private float baseCost;

	void Start()
	{
		baseCost = cost;
	}

	void Update()
	{
		iteminfo.text = itemName + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, false) + "  Souls:  " + tickvalue + "/s";
	}

	public void PurchasedItems()
	{
		if (click.Souls >= cost)
		{
			click.Souls -= cost;
			count += 1;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}

}
