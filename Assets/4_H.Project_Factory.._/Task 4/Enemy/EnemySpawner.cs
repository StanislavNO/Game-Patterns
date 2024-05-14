using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task4
{
    public class EnemySpawner : MonoBehaviour, IEnemyDeathNotifier
    {
        [SerializeField][Range(10, 200)] private int _maxSpawnWeight;
        [SerializeField] private float _spawnCooldown;

        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _factory;

        private List<Enemy> _spawnedEnemies;
        private Coroutine _spawn;

        private WeightIdentifier _enemyWeight;
        private int _weightCounter;

        public event Action<Enemy> Notified;

        private void Awake()
        {
            _enemyWeight = new WeightIdentifier();
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

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count < 0)
                return;

            _spawnedEnemies[UnityEngine.Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            WaitForSeconds delay = new(_spawnCooldown);
            EnemyType enemyType = (EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length);
            Vector3 spawnPosition = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)].position;

            if (_weightCounter > _maxSpawnWeight)
            {
                yield return delay;
            }

            Enemy enemy = _factory.Create(enemyType);

            enemy.MoveTo(spawnPosition);
            _spawnedEnemies.Add(enemy);
            enemy.Died += OnEnemyDied;

            enemy.Accept(_enemyWeight);
            _weightCounter += _enemyWeight.Value;

            yield return delay;
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Accept(_enemyWeight);
            _weightCounter -= _enemyWeight.Value;

            Notified.Invoke(enemy);
            enemy.Died -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
        }

        private class WeightIdentifier : IEnemyVisitor
        {
            public int Value { get; private set; }

            public void Visit(Elf elf)
            {
                Value = 10;
            }

            public void Visit(Ork ork)
            {
                Value = 30;
            }

            public void Visit(Human human)
            {
                Value = 5;
            }

            public void Visit(Robot robot)
            {
                Value = 20;
            }
        }
    }
}