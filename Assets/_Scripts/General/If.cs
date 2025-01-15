using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLocation = 20;
        int spawnLocation = 20;
        if (playerLocation == spawnLocation) this.Spawn();
        else this.notSpawn();
    }

    void Spawn()
    {
        Debug.Log("Spawn");
    }

    void notSpawn()
    {
        Debug.Log("notSpawn");
    }
}
