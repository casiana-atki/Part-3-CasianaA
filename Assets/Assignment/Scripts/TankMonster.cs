using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankyMonster : MonsterBase 
{
    public TankyMonster()
    {
        health = 10; 
    }

    public override int GetHealth()
    {
        return (int)health;
    }

    protected override void Update()
    {

        growthdiv = 40; 
        base.Update();

        if (monsterSize >= 0.5f)
        {
            PlayerHealth.DealDamageToPlayer(3);
            Destroy(gameObject);
        }

    }


}
