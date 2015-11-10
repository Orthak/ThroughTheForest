using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public GameObject escapeMenu;

	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (escapeMenu.activeSelf == false)
				escapeMenu.SetActive(true);
			else
				escapeMenu.SetActive(false);
		}
	}
}
