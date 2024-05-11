using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private EnemyConfig _enemyConfig;
        [SerializeField] List<EnemySpawner> _spawners;

        private GameLooper _gameLooper;
        private FactorySwitcher _factorySwitcher;

        private OrkFactory _orkFactory;
        private ElfFactory _elfFactory;

        private void Awake()
        {
            _orkFactory = new(_enemyConfig);
            _elfFactory = new(_enemyConfig);
            _gameLooper = new();

            _factorySwitcher = new FactorySwitcher(_orkFactory, _elfFactory);

            _gameLooper.AddTickable(_factorySwitcher);

            InitSpawners();
        }

        private void Update()
        {
            _gameLooper.Update();
        }

        private void InitSpawners()
        {
            int factoryIndex = 0;

            EnemyFactory[] factories =
            {
                _elfFactory,
                _orkFactory
            };

            foreach(EnemySpawner spawner in _spawners)
            {
                spawner.SetFactory(factories[factoryIndex]);

                factoryIndex++;

                if (factoryIndex == factories.Length)
                    factoryIndex = 0;
            }
        }
    }
}