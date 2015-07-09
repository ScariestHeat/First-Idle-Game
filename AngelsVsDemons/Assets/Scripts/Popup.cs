using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour {

	Canvas canvas;

	void Start()
	{
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
	}

	public void PopupWindow()
	{
		canvas.enabled = !canvas.enabled;
	}

}
