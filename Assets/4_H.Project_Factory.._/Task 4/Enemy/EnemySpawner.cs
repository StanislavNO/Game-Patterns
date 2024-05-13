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

        private EnemyVisitor _enemyWeight;
        private int _weightCounter;

        public event Action<Enemy> Notified;

        private void Awake()
        {
            _enemyWeight = new EnemyVisitor();
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
            _weightCounter += _enemyWeight.CurrencyWeight;

            yield return delay;
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Accept(_enemyWeight);
            _weightCounter -= _enemyWeight.CurrencyWeight;

            Notified.Invoke(enemy);
            enemy.Died -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int CurrencyWeight { get; private set; }

            public void Visit(Elf elf)
            {
                CurrencyWeight = 10;
            }

            public void Visit(Ork ork)
            {
                CurrencyWeight = 30;
            }

            public void Visit(Human human)
            {
                CurrencyWeight = 5;
            }

            public void Visit(Robot robot)
            {
                CurrencyWeight = 20;
            }
        }
    }
}