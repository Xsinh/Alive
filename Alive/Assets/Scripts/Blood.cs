using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour 
{
	public GameObject blood;
	float i = 0;
	void Update ()
	{	
		i += 0.01f;
		blood.gameObject.transform.localScale = new Vector3 (i,i,0);
	}
}
