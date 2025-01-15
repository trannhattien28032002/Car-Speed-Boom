using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;

    public GameObject spawnPos;
    public List<GameObject> objects;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public string spawnPosName = "";
    public string prefabName = "";
    public int maxObj = 1;
    public int layerOrder = 0;

    private void Awake()
    {
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objPrefab.SetActive(false);
        this.objects = new List<GameObject>();
        this.layerOrder = (int)this.objPrefab.transform.position.z;
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual GameObject Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return null;
        if (this.objects.Count >= this.maxObj) return null;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return null;
        this.spawnTimer = 0;

        Vector3 pos = this.spawnPos.transform.position;
        pos.z = this.layerOrder;
        return this.Spawn(pos);
    }

    protected virtual GameObject Spawn(Vector3 pos)
    {

        GameObject obj = Instantiate(this.objPrefab);
        obj.transform.position = this.spawnPos.transform.position;
        obj.transform.parent = transform;
        obj.SetActive(true);

        this.objects.Add(obj);
        return obj;
    }

    protected virtual void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.objects.Count; i++)
        {
            minion = this.objects[i];
            if (minion == null) this.objects.RemoveAt(i);
        }
    }
}
