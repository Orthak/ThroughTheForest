using UnityEngine;
using System.Collections;

public class Rock : Item 
{
	public GameObject throwBox;

	public Rock()
	{
		itemName = "Rock";
		useType = ItemUseType.Throw;
		materialType = ItemMaterialType.Stone;
	}

	/// <summary>
	/// When the player instanciates the item to throw, we need to apply the force
	/// the player applies to it after it is created.
	/// </summary>
	void Start()
	{
		GetComponent<Rigidbody>().AddForce((throwBox.transform.forward) * 30f, ForceMode.Impulse);
	}
}
