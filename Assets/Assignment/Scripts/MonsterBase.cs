using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{ 
    protected float monsterSize;
    protected float growthdiv = 25;
    protected float health = 4; 

    public static List<MonsterBase> AllMonsters = new List<MonsterBase>();

    //This is the basic function that will be used by all of the monsters. It makes them grow larger and gives the impression that they are getting closer. 
    protected virtual void Start()
    {
        monsterSize = 0;
        transform.localScale = Vector3.zero;
        AllMonsters.Add(this); 
    }

    public MonsterBase()
    {
        health = 2; 
    }

    public virtual int GetHealth()
    {
        return (int)health; 
    }

    protected virtual void Update()
    {
        growthdiv = 25f; 
        monsterSize += (Time.deltaTime/growthdiv);
        Vector3 scale = new Vector3(monsterSize, monsterSize, monsterSize);
        transform.localScale = scale;


    }
    public void TakeDamage()
    {
        foreach (MonsterBase monster in AllMonsters)
        {
            if (monster != null && Vector3.Distance(monster.transform.position, PlayerCursor.Instance.transform.position) < 2f)
            {
                if (health > 0)
                {
                    health -= 1; 
                    Debug.Log("Dealing damage to monster");
                }
                else if (health <= 0)
                {
                    Destroy(gameObject); 
                }    
                
            }
        }
    }
}
