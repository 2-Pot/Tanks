using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLoader : MonoBehaviour
{
	private void Start()
	{
		AudioListener.volume = PlayerPrefs.GetFloat("mainVolume");
	}
}
