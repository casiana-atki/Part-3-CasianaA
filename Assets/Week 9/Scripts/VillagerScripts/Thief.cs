using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{

    public GameObject knifePrefab;
    public Transform knifeSpawn1;
    public Transform knifeSpawn2; 

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        base.Attack();
        Instantiate(knifePrefab, knifeSpawn1.position, knifeSpawn1.rotation);
        Instantiate(knifePrefab, knifeSpawn2.position, knifeSpawn2.rotation); 
    }
}
