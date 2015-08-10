using UnityEngine;
using System.Collections;

public class ItemCountDisplay : MonoBehaviour {

	public UnityEngine.UI.Text iteminfo;
	public Itemmanager itemcount;
	public string itemname;

	void Update()
	{
		iteminfo.text = itemname + "" + " " + itemcount.count;
	}

}
