using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorChanger : MonoBehaviour
{

    [SerializeField] Image[] UIElements;
    [SerializeField] bool isPlayerOne;

    // Start is called before the first frame update
    void Start()
    {
        if (isPlayerOne)
        {
            foreach (var item in UIElements)
            {
                item.color = new Color(PlayerPrefs.GetFloat("TankR1"), PlayerPrefs.GetFloat("TankG1"), PlayerPrefs.GetFloat("TankB1"), 0.75f);
			}
		}
        else
        {
			foreach (var item in UIElements)
			{
				item.color = new Color(PlayerPrefs.GetFloat("TankR2"), PlayerPrefs.GetFloat("TankG2"), PlayerPrefs.GetFloat("TankB2"), 0.75f);
			}
		}
    }
}
