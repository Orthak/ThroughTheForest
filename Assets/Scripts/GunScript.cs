using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour 
{
	public GameObject bullet;
	public GameObject barrel;
	public float speed;

	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
			Shoot();
	}

	void Shoot()
	{
		var bulletInstance = Instantiate(bullet, barrel.transform.position, barrel.transform.rotation)
			as GameObject;
		bulletInstance.rigidbody.AddForce(bulletInstance.transform.forward * speed,
										  ForceMode.Impulse);
	}
}