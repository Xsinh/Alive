using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VK_Click : MonoBehaviour
{	
	public GameObject VK;
	const string ApplicationLink = "https://vk.com/id167552520";
	const string Title = "Alives";
	const string Description = "Автор типа";
	const string ImageUrl = "https://leadingpersonality.files.wordpress.com/2013/05/smile.jpg";

	void OnMouseDown()
	{
		VK.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 120);
	}

	void OnMouseUp()
	{
		VK.GetComponent<SpriteRenderer> ().color = new Color32 (0, 221, 121, 255);
		Application.OpenURL("http://m.vk.com/share.php?url=" + ApplicationLink
			+ "&title=" + Title
			+ "&description=" + Description
			+ "&image=" + ImageUrl);
	}
}
