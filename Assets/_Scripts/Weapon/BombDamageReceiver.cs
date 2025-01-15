using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{
    //[Header("Bomb")]

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead()) 
        { 
            Destroy(gameObject);
            Vector3 pos = transform.position;
            pos.z += -4;
            EffectManager.instance.SpawnVFX("Explosion_B", pos, transform.rotation);
        }
    }
}
