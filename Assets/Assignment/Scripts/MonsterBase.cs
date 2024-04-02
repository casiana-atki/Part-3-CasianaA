using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{
    protected float monsterSize;

    //This is the basic function that will be used by all of the monsters. It makes them grow larger and gives the impression that they are getting closer. 
    protected void Start()
    {
        monsterSize = 0;
    }


    protected void Update()
    {
        monsterSize += (Time.deltaTime/25);
        Vector3 scale = new Vector3(monsterSize, monsterSize, monsterSize);
        transform.localScale = scale;


    }
}
