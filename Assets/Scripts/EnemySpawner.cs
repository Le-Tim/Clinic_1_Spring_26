using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnInterval = 3.5f;
    void Start()
    {
        StartCoroutine(SpawnEnemy(spawnInterval, enemyPrefab));
    }
    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPos = new Vector3(
            Random.Range(-5f, 5f), 0.2f, Random.Range(-6f, 6f)
        );
        Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
