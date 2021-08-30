using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemy;
    private Random random;
    
    private void Start()
    {
        random = new Random();
        StartCoroutine(SpawnEnemy());
        
    }

    private IEnumerator SpawnEnemy()
    {
        Debug.Log(random.Next(-5, 5));
        Instantiate(enemy, new Vector3(10, random.Next(-5, 5), 0), Quaternion.identity);
        yield return new WaitForSeconds(1f);
        StartCoroutine(SpawnEnemy());
    }
}
