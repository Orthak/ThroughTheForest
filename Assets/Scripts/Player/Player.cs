using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public PlayerInventory playerInventory;
	public Item item;
	public float speed;

	void Update () 
	{
		if (Input.GetMouseButtonDown(1))
			if(playerInventory.GetItemsList().Count > 0)
				Attack();
	}

	void Attack()
	{
		Instantiate(item, transform.position, transform.rotation);
		playerInventory.SubtractItem(playerInventory.GetItem("Rock"));
	}
}
