using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facebook_Click : MonoBehaviour
{

	public GameObject facebook;

	void OnMouseDown()
	{
		facebook.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 120);
	}

	void OnMouseUp()
	{
		facebook.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 255);
	}
}
