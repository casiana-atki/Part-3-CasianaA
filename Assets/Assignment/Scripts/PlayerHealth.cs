using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PlayerHealth : MonoBehaviour
{
    private static int health = 3;

    private static int CurrentHealth
    {
        get { return health; }
    }

    public static void PlayerDamaged(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene("YouLose");
        }
        
    }

    public static void DealDamageToPlayer(int damageAmount)
    {
        PlayerDamaged(damageAmount); 
    }

}
