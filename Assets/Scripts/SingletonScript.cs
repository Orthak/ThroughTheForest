using UnityEngine;
using System.Collections;

public class SingletonScript : MonoBehaviour 
{
	static bool isCreated = false;

	void Awake() 
	{
		if (!isCreated)
		{
			DontDestroyOnLoad(gameObject);
			isCreated = true;
		}
		else
			Destroy(gameObject);
	}
}