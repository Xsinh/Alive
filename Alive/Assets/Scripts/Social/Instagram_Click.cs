using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instagram_Click : MonoBehaviour 
{

	public GameObject instagram;

	void OnMouseDown()
	{
		instagram.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 120);
	}

	void OnMouseUp()
	{
		instagram.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 255);
	}
}
