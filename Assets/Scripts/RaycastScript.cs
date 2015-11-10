using UnityEngine;
using System.Collections;

public class RaycastScript : MonoBehaviour 
{
	public LayerMask layermask;
	
	void Update () 
	{
		RaycastHit hit = new RaycastHit();
		if (Physics.Raycast(transform.position, transform.forward, out hit, 500f,layermask))
			Debug.DrawLine(transform.position, hit.point);
	}
}