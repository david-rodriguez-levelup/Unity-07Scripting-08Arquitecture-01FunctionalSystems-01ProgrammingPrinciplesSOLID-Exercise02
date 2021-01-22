using System.Collections;
using UnityEngine;

/// <summary>
/// Spawns an enemy in the the top area of the level each <see cref="timeBetweenEnemies"/> seconds.
/// If instantiated enemies have a <see cref="SelfDestroyOnTriggerEnter"/> component attached then the bottom 
/// collider is passed to <see cref="SelfDestroyOnTriggerEnter.SetStaticTriggerCollider(UnityEngine.Collider)"/>.
/// </summary>
public class LevelEnemySpawner : MonoBehaviour
{

    /// Inspector
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float timeBetweenEnemies;

    /// Internal
    private BoxCollider topCollider;
    private float minSpawnPointX;
    private float maxSpawnPointX;
    private float spawnPointY;
    private BoxCollider bottomCollider;

    private void Awake()
    {
        topCollider = transform.Find("[Top]").GetComponent<BoxCollider>();
        bottomCollider = transform.Find("[Bottom]").GetComponent<BoxCollider>();
    }

    private void Start()
    {
        InitSpawnPoints();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemies);
        }
    }

    private void InitSpawnPoints()
    {
        Bounds topColliderBounds = topCollider.bounds;

        /// Find min/max X spawn points based on top collider's box bounds.
        minSpawnPointX = topColliderBounds.min.x;
        maxSpawnPointX = topColliderBounds.max.x;

        /// Find Y spawn point based on top collider's box center.
        spawnPointY = topColliderBounds.center.y;
    }

    private void SpawnEnemy()
    {
        float randomSpawnPointX = Random.Range(minSpawnPointX, maxSpawnPointX);

        /// Instantiate enemy!
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(randomSpawnPointX, spawnPointY, 0f), new Quaternion());

        /// Assign static trigger for self-destruction.
        SelfDestroyOnTriggerEnter selfDestroyOnTriggerEnter = enemy.GetComponent<SelfDestroyOnTriggerEnter>();
        if (selfDestroyOnTriggerEnter != null)
        {
            selfDestroyOnTriggerEnter.SetStaticTriggerCollider(bottomCollider);
        } 
    }

}
