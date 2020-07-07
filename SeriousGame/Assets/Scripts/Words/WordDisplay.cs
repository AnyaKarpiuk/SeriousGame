using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Displays words' objects

public class WordDisplay : MonoBehaviour
{

	public float fallSpeedCurrent = 3f;
    public float targetSpeed = 10f;

	private void Update()
	{
		// instantiate the speed of the falling objects
		transform.Translate(0f, -fallSpeedCurrent * Time.deltaTime, 0f);

		// increase the speed
		if(fallSpeedCurrent < targetSpeed) fallSpeedCurrent += Time.deltaTime;
	}

}
