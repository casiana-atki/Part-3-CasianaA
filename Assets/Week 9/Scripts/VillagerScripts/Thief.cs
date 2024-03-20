using JetBrains.Annotations;
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
    public float dashTime = 2;
  //  float timer;

   // public float dashSpeed; 
  //  bool isDashing;
    


    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 10; 
        while (speed > 3)
        {
            yield return null; 
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f); 
        Instantiate(knifePrefab, knifeSpawn1.position, knifeSpawn1.rotation);
        yield return new WaitForSeconds(0.1f); // forces it to wait 0.1 seconds before spawning this at the end, it also makes a slight pause between both knives spawning 
        Instantiate(knifePrefab, knifeSpawn2.position, knifeSpawn2.rotation);
    }

    //Apart of the fix for the naming shown in Character Control 
    public override string ToString()
    {
        return "The Thief";
    }
}

