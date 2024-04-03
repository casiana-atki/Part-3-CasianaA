using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject spawnPoint;
    public List<GameObject> monsterPrefabs;
    Coroutine coroutine; 

    void Start()
    {
        StartCoroutine(PlaceMonsters());
    }

    void Update()
    {
        
    }

    IEnumerator PlaceMonsters() 
    {
        while (true)
        {
            Vector3 position = new Vector3(Random.Range(12f, 26f), 9f, 0.03f); // Coordinates to instantiate objects, makes it so they randomly spawn between X 12 and 26 
            int randomIndex = Random.Range(0, monsterPrefabs.Count); // Randomly selects 1 monster from the list to be spawned 
            GameObject objectToInstantiate = monsterPrefabs[randomIndex];
            Instantiate(objectToInstantiate, position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }

    }
}
    
