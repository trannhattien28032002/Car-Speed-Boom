using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [Header("Enemy")]
    public EnemyCtrl enemyCtrl; //Controller

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset()
    {
        this.hp = 3;
    }

    public override void Receive(int damage)
    {
        this.hp -= damage;
        if (this.IsDead())
        {
            Vector3 pos = transform.position;
            pos.z += -4;
            EffectManager.instance.SpawnVFX("Explosion_A", pos, transform.rotation);
            this.enemyCtrl.despawner.Despawn();
        }
    }
}
