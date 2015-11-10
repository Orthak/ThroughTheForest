using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour 
{
	public float secondsToWait;

	void Start()
	{
		Destroy(this.gameObject, secondsToWait);
	}
}