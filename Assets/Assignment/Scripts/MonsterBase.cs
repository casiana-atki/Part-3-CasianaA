using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{ 
    protected float monsterSize;
    protected float growthdiv = 25; 

    //This is the basic function that will be used by all of the monsters. It makes them grow larger and gives the impression that they are getting closer. 
    protected virtual void Start()
    {
        monsterSize = 0;
        transform.localScale = Vector3.zero;
    }


    protected virtual void Update()
    {
        growthdiv = 25f; 
        monsterSize += (Time.deltaTime/growthdiv);
        Vector3 scale = new Vector3(monsterSize, monsterSize, monsterSize);
        transform.localScale = scale;


    }
}
