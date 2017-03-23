using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitter_Click : MonoBehaviour 
{

	public GameObject twitter;

	void OnMouseDown()
	{
		twitter.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 120);
	}

	void OnMouseUp()
	{
		twitter.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 255);
	}
}
