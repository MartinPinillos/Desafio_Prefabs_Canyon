using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float spawnInterval = 2f;
    [SerializeField] float spawnDelay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnemy()
    {
        Instantiate(bulletPrefab, transform);
    }
}
