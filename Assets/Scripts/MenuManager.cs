using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Interfaces")]
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject colorMenuUI;
    [SerializeField] GameObject mapMenuUI;
	[SerializeField] GameObject optionsMenuUI;

    [Header("Tank Models")]
    [SerializeField] GameObject player1Tank;
    [SerializeField] GameObject player2Tank;

	[Header("Tank Materials")]
	[SerializeField] Material player1Material;
	[SerializeField] Material player2Material;

	private int currentActive = 0;
	private bool isOptionsMenuActive = false;

    public void GoNext()
    {
		Vibration.Vibrate(200);
		switch (currentActive)
        {
            case 0:
                mainMenuUI.SetActive(false);
                colorMenuUI.SetActive(true);
                currentActive++;
                break;

            case 1:
                colorMenuUI.SetActive(false);
                mapMenuUI.SetActive(true);
                currentActive++;
                break;

            default:
                break;
        }
    }

    public void GoBack()
    {
		Vibration.Vibrate(200);
		switch (currentActive)
        {
            case 2:
                mapMenuUI.SetActive(false);
                colorMenuUI.SetActive(true);
                currentActive--;
                break;

            case 1:
                colorMenuUI.SetActive(false);
                mainMenuUI.SetActive(true);
                currentActive--;
                break;

            default:
                break;
        }
    }

	public void ToggleOptions()
	{
		Vibration.Vibrate(200);
		isOptionsMenuActive = !isOptionsMenuActive;
        mainMenuUI.SetActive(!isOptionsMenuActive);
		optionsMenuUI.SetActive(isOptionsMenuActive);
    }

	public void LoadGameDesert()
	{
		Vibration.Vibrate(500);
		mapMenuUI.SetActive(false);
		SceneManager.LoadScene("_Complete-Game");
	}

	public void LoadGameForest()
	{
		Vibration.Vibrate(500);
		mapMenuUI.SetActive(false);
		SceneManager.LoadScene("_Complete-GameForest");
	}

    public void SavePlayer1Color(string color)
    {
		Vibration.Vibrate(200);

		Color selectedColor = Color.white; // Default color if not found

		switch (color)
		{
			case "red":
				selectedColor = Color.red;
				break;

			case "pink":
				selectedColor = new Color(1f, 0.41f, 0.71f); // Pink
				break;

			case "purple":
				selectedColor = new Color(0.5f, 0f, 0.5f); // Purple
				break;

			case "blue":
				selectedColor = Color.blue;
				break;

			case "metal":
				selectedColor = new Color(0.75f, 0.75f, 0.75f); // Metal
				break;

			case "green":
				selectedColor = Color.green;
				break;

			case "lime":
				selectedColor = new Color(0.75f, 1f, 0f); // Lime
				break;

			case "gold":
				selectedColor = new Color(1f, 0.84f, 0f); // Gold
				break;

			case "orange":
				selectedColor = new Color(1f, 0.65f, 0f); // Orange
				break;

			case "black":
				selectedColor = Color.black;
				break;

			default:
				Debug.LogWarning("Selected color is not predefined.");
				break;
		}

		// Get all of the renderers of the tank.
		MeshRenderer[] renderers = player1Tank.GetComponentsInChildren<MeshRenderer>();

		// Go through all the renderers...
		for (int i = 0; i < renderers.Length; i++)
		{
			// ... set their material color to the color specific to this tank.
			renderers[i].material.color = selectedColor;
		}

		PlayerPrefs.SetFloat("TankR1", selectedColor.r);
		PlayerPrefs.SetFloat("TankG1", selectedColor.g);
		PlayerPrefs.SetFloat("TankB1", selectedColor.b);
	}

    public void SavePlayer2Color(string color)
    {
		Vibration.Vibrate(200);

		Color selectedColor = Color.white; // Default color if not found

		switch (color)
		{
			case "red":
				selectedColor = Color.red;
				break;

			case "pink":
				selectedColor = new Color(1f, 0.41f, 0.71f); // Pink
				break;

			case "purple":
				selectedColor = new Color(0.5f, 0f, 0.5f); // Purple
				break;

			case "blue":
				selectedColor = Color.blue;
				break;

			case "metal":
				selectedColor = new Color(0.75f, 0.75f, 0.75f); // Metal
				break;

			case "green":
				selectedColor = Color.green;
				break;

			case "lime":
				selectedColor = new Color(0.75f, 1f, 0f); // Lime
				break;

			case "gold":
				selectedColor = new Color(1f, 0.84f, 0f); // Gold
				break;

			case "orange":
				selectedColor = new Color(1f, 0.65f, 0f); // Orange
				break;

			case "black":
				selectedColor = Color.black;
				break;

			default:
				Debug.LogWarning("Selected color is not predefined.");
				break;
		}

		// Get all of the renderers of the tank.
		MeshRenderer[] renderers = player2Tank.GetComponentsInChildren<MeshRenderer>();

		// Go through all the renderers...
		for (int i = 0; i < renderers.Length; i++)
		{
			// ... set their material color to the color specific to this tank.
			renderers[i].material.color = selectedColor;
		}

		PlayerPrefs.SetFloat("TankR2", selectedColor.r);
		PlayerPrefs.SetFloat("TankG2", selectedColor.g);
		PlayerPrefs.SetFloat("TankB2", selectedColor.b);
	}

	public static void MoveAndroidApplicationToBack()
	{
		AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		activity.Call<bool>("moveTaskToBack", true);
	}
}
