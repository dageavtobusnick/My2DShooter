using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField]
    public List<EnemySpawner> spawners = new List<EnemySpawner>();

    public GameObject Boss;
    public GameObject spawnedBoss;

    // Update is called once per frame
    void Update()
    {
        if (spawners.Count == 0&&spawnedBoss==null)
            spawnedBoss=Instantiate(Boss, gameObject.transform.position, Quaternion.identity);
        spawners=spawners.Where(x=>x.currentlySpawned<=x.maxSpawn).ToList();
    }
    
}
