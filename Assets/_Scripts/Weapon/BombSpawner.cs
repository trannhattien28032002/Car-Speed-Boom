using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    //private void Awake()
    //{
    //    this.objects = new List<GameObject>();
    //    this.spawnPos = GameObject.Find("BombSpawnPos");
    //    this.objPrefab = GameObject.Find("BombPrefab");
    //    this.objPrefab.SetActive(false);
    //}

    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 17;
    }
}
