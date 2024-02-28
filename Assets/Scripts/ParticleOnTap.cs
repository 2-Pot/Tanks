using UnityEngine;

public class ParticleOnTap : MonoBehaviour
{
	public AudioClip tapSound; // Sound to play on tap
	private AudioSource audioSource; // Reference to the AudioSource component

	void Start()
	{
		// Get the AudioSource component from the GameObject or create one if not present
		audioSource = GetComponent<AudioSource>();
		if (audioSource == null)
		{
			audioSource = gameObject.AddComponent<AudioSource>();
		}
	}

	void Update()
	{
		// Check for touch input on mobile devices
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			// Play the tap sound
			PlayTapSound();
		}
	}

	void PlayTapSound()
	{
		// Play the tap sound
		if (tapSound != null && audioSource != null)
		{
			audioSource.PlayOneShot(tapSound);
		}
	}
}