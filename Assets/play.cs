using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	void OnTriggerEnter(Collider otherObj)
	{
		if (otherObj.tag == "MainCamera")
		{
			GetComponent<AudioSource>().Play();
		}
		else {
			GetComponent<AudioSource>().Stop();
		}

		Debug.Log ("Yes");
	}
}
