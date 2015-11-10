using UnityEngine;
using System.Collections;

public class UpdateTargetsLabel : MonoBehaviour 
{
	GameObject[] targetsRemaining;
	TextMesh textMesh;

	void Start () 
	{
		RefreshTargetArray();
		textMesh = GetComponent<TextMesh>();
	}
	
	void Update () 
	{
		RefreshTargetArray();
		textMesh.text = string.Format("Targets Remaining: {0}", targetsRemaining.Length.ToString());
	}

	void RefreshTargetArray()
	{
		targetsRemaining = GameObject.FindGameObjectsWithTag("Target");
	}
}