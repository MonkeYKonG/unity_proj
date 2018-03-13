using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPoolScript : MonoBehaviour {
    public float spawnRate = 2.5f;
    public List<Transform> AvailableObjects;

    private float spawnCooldown;

    void Start()
    {
        spawnCooldown = 0f;
    }

    void Update()
    {
        if (spawnCooldown > 0)
            spawnCooldown -= Time.deltaTime;
        if (spawnCooldown <= 0f)
            GenerateEnemy(Random.Range(0, AvailableObjects.Count - 1));
    }

    public void GenerateEnemy(int index)
    {
        if (index < AvailableObjects.Count)
        {
            Instantiate(AvailableObjects[0]);
            spawnCooldown = spawnRate;
        }
    }
}
