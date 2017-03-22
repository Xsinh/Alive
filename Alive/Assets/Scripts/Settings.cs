using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour 
{
	public GameObject Gear;

	void OnMouseDown()
	{
		Gear.GetComponent<Animator> ().Play ("gear_1");
	}

	void OnMouseUp()
	{
		Gear.GetComponent<Animator> ().Play ("gear");
	}
}
