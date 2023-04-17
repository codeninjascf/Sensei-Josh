using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int EnemiesToSpawn;
    public GameObject[] Enemy;
    float TimeToMove = 1;
    // Update is called once per frame
    void Update()
    {
        if (EnemiesToSpawn != 0)
        {
            if (TimeToMove <= 0)
            {
                int EnemyType = Random.Range(1, 3);
                GameObject NewEnemy = Instantiate(Enemy[EnemyType], transform);
                NewEnemy.GetComponent<EnemyMovement>();
            }
            else
                TimeToMove -= 1 * Time.deltaTime;
        }
    }
}
