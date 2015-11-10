using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerInventory : MonoBehaviour
{
	public TextMesh itemText;

	List<Item> items = new List<Item>();

	public Item GetItem(string itemName)
	{
		return items
			.Where(i => i.itemName == itemName)
			.FirstOrDefault();
	}

	public List<Item> GetItemsList()
	{
		return items;
	}

	public void AddItem(Item itemToAdd)
	{
		items.Add(itemToAdd);
		UpdateItemText(itemToAdd);
	}

	public void SubtractItem(Item itemToRemove)
	{
		items.Remove(itemToRemove);
		UpdateItemText(itemToRemove);
	} 
	
	/// <summary>
	/// We need to notify the player of items that are added and removed from thier
	/// inventory. They also need to know how many items they have at each change.
	/// </summary>
	/// <param name="toUpdate">The item that was added/removed</param>
	void  UpdateItemText(Item toUpdate)
	{
		int itemNumber = 0;
		if (items.Count() > 0)
			itemNumber = items
				.Where(i => i.itemName == toUpdate.itemName)
				.Count();
		
		itemText.text = string.Format("Obtained {0} (x{1})\n", toUpdate.itemName, itemNumber);
	}
}
