using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	float health = 100f;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Bullet")
			if (health <= 50)
				Destroy(this.gameObject);
			else
				health -= 50f;
	}
}