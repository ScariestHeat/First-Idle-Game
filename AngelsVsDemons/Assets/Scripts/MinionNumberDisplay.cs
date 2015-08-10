using UnityEngine;
using System.Collections;

public class MinionNumberDisplay : MonoBehaviour {

	public UnityEngine.UI.Text minioninfo;
	public string minionname;
	public AngelBuying minions;



	void Update()
	{
		minioninfo.text = minionname + "" + " " + minions.count;
	}
}
