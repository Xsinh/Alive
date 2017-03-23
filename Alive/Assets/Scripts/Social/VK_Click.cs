using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VK_Click : MonoBehaviour
{	
	public GameObject VK;

	void OnMouseDown()
	{
		VK.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 120);
	}

	void OnMouseUp()
	{
		VK.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 255);
	}
}
