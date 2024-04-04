using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterBase : MonoBehaviour
{
    protected float monsterSize;
    protected float growthdiv = 25;
    protected float health = 4;
    protected float monstersKilled = 0; 

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
        monsterSize += (Time.deltaTime / growthdiv);
        Vector3 scale = new Vector3(monsterSize, monsterSize, monsterSize);
        transform.localScale = scale;

        if (monsterSize >= 0.5f)
        {
            PlayerHealth.DealDamageToPlayer(1);
            Destroy(gameObject);
        }
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
                }
                else if (health <= 0)
                {
                    Destroy(gameObject);
                    monstersKilled += 1; 

                    //If you are playing the game and wondering if this actually works, it does, it just takes a really long time. You can test it if you want because by changing it to 1, it happens as soon as you kill just 1. 
                    if (monstersKilled == 30)
                    {
                        SceneManager.LoadScene("YouWin");
                    }
                }    
                
            }
        }
    }

}
