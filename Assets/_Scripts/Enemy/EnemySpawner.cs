using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    //private void Awake()
    //{
    //    this.spawnPos = GameObject.Find("EnemySpawnPos");
    //    this.objPrefab = GameObject.Find("EnemyPrefab");
    //    this.objPrefab.SetActive(false);
    //    this.objects = new List<GameObject>(); 
    //}

    private void Reset()
    {
        this.spawnPosName = "EnemySpawnPos";
        this.prefabName = "EnemyPrefab";
    }
    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }
}
