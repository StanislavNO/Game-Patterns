using Assets.Task4;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Project4.Task2
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;

        [SerializeField] private List<Transform> _spawnPoints;

        private EnemyFactory _enemyFactory;

        private Coroutine _spawn;

        public void Construct(EnemyFactory factory)
        {
            _enemyFactory = factory;
        }

        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            WaitForSeconds delay = new(_spawnCooldown);

            while (true)
            {
                EnemyType enemyType = (EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length);
                IEnemy enemy = _enemyFactory.Create();

                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);

                yield return delay;
            }
        }
    }
}