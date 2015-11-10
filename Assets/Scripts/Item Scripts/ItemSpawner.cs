using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemSpawner : MonoBehaviour
{
    // This is the total number of items that can be instanciated at any one time.
    public int amountToSpawn = 50;
    public Item itemToSpawn;

    GameObject[] spawnLocations;

    void Start()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("ItemLocation");

        foreach (var item in spawnLocations)
        {
            System.Console.WriteLine(item.tag);
        }

        SpawnItems();
    }

    void Update()
    {

    }

    void SpawnItems()
    {
        if (spawnLocations.Length > 0)
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                var rand = Random.Range(0, spawnLocations.Length - 1);
                GameObject currentSpawn = spawnLocations[rand];
                Instantiate(itemToSpawn, currentSpawn.transform.position, Quaternion.identity);
                amountToSpawn--;
            }
        }
    }
}