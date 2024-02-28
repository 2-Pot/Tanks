using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldChecker : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public bool isFirePressed = false;

	// Start is called before the first frame update
	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("BUTTON DOWN");
		isFirePressed = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log("BUTTON UP");
		isFirePressed = false;
	}
}
