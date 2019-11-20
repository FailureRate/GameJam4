using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Volume")]
    [SerializeField] private SpawnerVolume volume;
    [Header("Spawning")]
    [SerializeField] private int maximumSpawns;
    [SerializeField] private float spawnTime;
    [SerializeField, Min(0.01f)] private float spawnTimer;
    [SerializeField, Min(0)] private float spawnTimerRange;
    [SerializeField] private GameObject instantiable;
    [SerializeField] private List<GameObject> spawnedInstances;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(spawnTimer - spawnTimerRange, spawnTimer + spawnTimerRange);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Vector3 spawnPoint = volume.SpawnPoint();

            for (int i = 0; i < spawnedInstances.Count; i++)
            {
                if (spawnedInstances[i] == null)
                {
                    spawnedInstances.RemoveAt(i);
                    i--;
                }
            }

            if (spawnedInstances.Count < maximumSpawns)
            {
                spawnedInstances.Add(Instantiate(instantiable, spawnPoint, new Quaternion()));
            }

            spawnTime += Random.Range(spawnTimer - spawnTimerRange, spawnTimer + spawnTimerRange);
        }
    }
}
