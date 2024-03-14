using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{

    public GameObject knifePrefab;
    public Transform knifeSpawn1;
    public Transform knifeSpawn2;
    public float currentTime = 0;


    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        //Similar to the archer but I did two positions since the thief has 2 knives. I tried to match them up to the animation 
        base.Attack();
        Instantiate(knifePrefab, knifeSpawn1.position, knifeSpawn1.rotation);
        Instantiate(knifePrefab, knifeSpawn2.position, knifeSpawn2.rotation);

        

        if (Input.GetMouseButtonDown(1))
        {
            //Set the speed really high for the thief's dash. This is just a comment but I think it'd be really cool if there was an animation we could play to make it look smoother :,) oh well still fun!
            speed = 10;
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }



    }
}
