using UnityEngine;

public class TouchRotate : MonoBehaviour
{
	public GameObject targetObject; // The object to rotate
	public GameObject targetObject2;
	private Vector2 lastTouchPosition;
	public float rotationSpeed = 0.1f;
	public float leftSideThreshold = 0.5f; // Adjust this threshold to define the left side

	void Update()
	{
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);

			switch (touch.phase)
			{
				case TouchPhase.Began:
					lastTouchPosition = touch.position;
					break;

				case TouchPhase.Moved:
					if (targetObject != null)
					{
						Vector2 currentTouchPosition = touch.position;
						Vector2 touchDelta = currentTouchPosition - lastTouchPosition;

						if (currentTouchPosition.x < Screen.width * leftSideThreshold)
						{
							float rotationY = touchDelta.x * rotationSpeed;
							targetObject.transform.Rotate(Vector3.up, rotationY);
						} else
						{
							float rotationY = touchDelta.x * rotationSpeed;
							targetObject2.transform.Rotate(Vector3.up, rotationY);
						}

						lastTouchPosition = currentTouchPosition;
					}
					break;
			}
		}
	}
}
