using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxMinion = 7;
        for (int i = 0; i < maxMinion; i++)
        {
            this.Spawn();
        }
    }

    void Spawn()
    {
        Debug.Log("Spawn");
    }
}
