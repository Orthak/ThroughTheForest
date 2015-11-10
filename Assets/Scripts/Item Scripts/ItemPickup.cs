using UnityEngine;
using System.Collections;
using System;

public class ItemPickup : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public ItemSpawner itemSpawner;
    public Item itemToAdd;
    public LayerMask layerMask;

    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5, layerMask))
            if (Input.GetMouseButtonDown(0))
                if (hit.collider.tag == "Item")
                {
                    Item item = hit.collider.gameObject.GetComponent<Item>();
                    if (item != null)
                    {
                        GetItemInfo(item);
                        playerInventory.AddItem(itemToAdd);
                        Destroy(hit.collider.gameObject);
                        itemSpawner.amountToSpawn--;
                    }
                }

        Debug.DrawLine(transform.position, hit.point);
    }

    void GetItemInfo(Item item)
    {
        itemToAdd.name = item.name;
        itemToAdd.useType = item.useType;
        itemToAdd.materialType = item.materialType;
    }
}
