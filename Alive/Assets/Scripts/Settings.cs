using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour 
{
	public GameObject Gear,SettingsPanel,SoundCosmos;
	public GameObject[] Social = new GameObject[4];
	public Text Aud;
	bool gear = true;
	bool audio_cosmos = true;
	bool social = true;

	void OnMouseDown()
	{
		Gear.GetComponent<Animator> ().Play ("gear_1");
	}
		

	void OnMouseUp()
	{
		Gear.GetComponent<Animator> ().Play ("gear");
		switch (gear) {
			case true:
				SettingsPanel.SetActive (true);
				gear = false;
				break;
			case false:
				SettingsPanel.SetActive (false);
				gear = true;
				break;
		}
			
	}

	public void Sound()
	{	
		switch (audio_cosmos) {
		case true:
			SoundCosmos.GetComponent<AudioSource> ().Pause ();
			audio_cosmos = false;
			Aud.text = "On";
			break;
		case false:
			SoundCosmos.GetComponent<AudioSource> ().Play ();
			audio_cosmos = true;
			Aud.text = "Off";
			break;
		}

	}

	public void Socials()
	{
		switch (social)
		{
		case true:
			StartCoroutine (Soci ());
			social = false;
			break;
		case false:
			StartCoroutine (FuckTheSotial ());
			social = true;
			break;
		}
	}

	IEnumerator Soci()
	{
		for(int i = 0; i < 4; i++)
		{
			Social[i].SetActive(true);
			yield return new WaitForSeconds (0.1f);
		}
	}

	IEnumerator FuckTheSotial()
	{
		for(int i = 3; i >= 0; i--)
		{
			Social[i].SetActive(false);
			yield return new WaitForSeconds (0.05f);
		}
	}
}
