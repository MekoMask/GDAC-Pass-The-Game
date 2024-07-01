using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    [SerializeField] private GameObject ItemPrefab;
    [SerializeField] private Transform spawnPoint;
    private GameObject item;

    void Start()
    {
        SpawnItem();
    }

    private void Update()
    {
        if (item == null)
        {
            SpawnItem();
        }
    }

    void SpawnItem()
    {
        GameObject obj = Instantiate(ItemPrefab, spawnPoint.position, spawnPoint.rotation);
        item = obj;
    }
}
