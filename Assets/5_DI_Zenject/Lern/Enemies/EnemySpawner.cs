using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;

        private EnemyFactory _factory;
        private Coroutine _spawn;

        [Inject]
        private void Construct(EnemyFactory enemyFactory)
        {
            _factory = enemyFactory;
        }

        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if(_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            WaitForSeconds delay = new(_spawnCooldown);

            while (true)
            {
                Enemy enemy = _factory.Create((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)].position);
                yield return delay;
            }
        }
    }
}