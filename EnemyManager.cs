using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Array of prefabs (GameObject)
    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    public static EnemyManager instance;
    public Transform canvas;

    void Awake()
    {
        instance = this;
    }

    void CreateNewEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);

        curEnemy = obj.GetComponent<Enemy>();
    }

    public void DefeatEnemy(GameObject enemy)
    {
        // Destroys the current enemy and creates a new enemy.
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.instance.BackgroundCheck();
    }
}
