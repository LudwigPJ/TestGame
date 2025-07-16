using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private List<Transform> Spawnpoints;
        [SerializeField] private Transform playerTransform;

        void Start()
        {
            SpawnEnemy();
            SpawnEnemy();
        }

        public void SpawnEnemy()
        {
            
            Transform spawnPoint = Spawnpoints[UnityEngine.Random.Range(0, Spawnpoints.Count)];
            Enemy newEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            newEnemy.Init(playerTransform);

        }
        
    }


    
}
