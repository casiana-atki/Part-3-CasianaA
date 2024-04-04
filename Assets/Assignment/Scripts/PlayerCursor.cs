using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCursor : MonoBehaviour
{
    public float speed = 5f;
    Animator cursorAnimator;

    public static PlayerCursor Instance;

    void Start()
    {
        cursorAnimator = GetComponent<Animator>();
        Instance = this;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        transform.position = Vector3.Lerp(transform.position, mousePos, speed * Time.deltaTime);
        if (Input.GetMouseButtonUp(0))
        {
            cursorAnimator.SetTrigger("Shot");
            MonsterBase closestMonster = FindClosestMonster(); 
            
            if (closestMonster != null)
            {
                closestMonster.TakeDamage(); 
            }
        }
    }

    MonsterBase FindClosestMonster()
    {
        MonsterBase closestMonster = null;
        float closestDistance = float.MaxValue; 

        foreach (MonsterBase monster in MonsterBase.AllMonsters)
        {
            if (monster != null)
            {
                float distance = Vector3.Distance(monster.transform.position, transform.position);
                if (distance < closestDistance)
                { closestMonster = monster;
                    closestDistance = distance; 
                }
            }
            
        }
        return closestMonster;
    }
}
