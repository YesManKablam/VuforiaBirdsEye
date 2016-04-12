using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	void Update()
	{     
		float xAxisValue = Input.GetAxis("Horizontal");
		float yAxisValue = Input.GetAxis("Vertical");
		if(Camera.current != null)
		{
			Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, yAxisValue));
		}
	}
}