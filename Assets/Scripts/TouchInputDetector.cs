using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInputDetector : MonoBehaviour
{
	private void Update()
	{
		// Check if there's any touch input
		if (Input.touchCount > 0)
		{
			// Loop through all the touches
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);

				// Check if the touch phase is at the beginning (when the touch is first detected)
				if (touch.phase == TouchPhase.Began)
				{
					// Display a message on the screen
					Debug.Log("Touch detected at position: " + touch.position);
				}
			}
		}
	}
}

