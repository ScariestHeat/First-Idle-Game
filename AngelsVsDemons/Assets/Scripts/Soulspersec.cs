using UnityEngine;
using System.Collections;

public class Soulspersec : MonoBehaviour {

	public UnityEngine.UI.Text spsDisplay;
	public SoulClick click;
	public Itemmanager[] items;

	void Start()
	{
		StartCoroutine(AutoTick());
	}

	void Update()
	{
		spsDisplay.text = GetSoulsPerSec () + " souls/sec";
	}

	public float GetSoulsPerSec()
	{
		float tick = 0.00f;
		foreach(Itemmanager item in items)
		{
			tick += item.count * item.tickvalue;
		}
		return tick;
	}
	
	public void AutoSoulspersec()
	{
		click.Souls += GetSoulsPerSec() / 10;
	}
	
	IEnumerator AutoTick()
	{
		while (true)
		{
			AutoSoulspersec();
			yield return new WaitForSeconds(0.10f);
		}
	}
	
}
