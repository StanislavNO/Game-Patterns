using System;
using System.IO;
using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class EnemyFactory
    {
        private const string ConfigsPath = "Project_5/Enemies";
        private const string SmallConfig = "Small";
        private const string MediumConfig = "Medium";
        private const string LargeConfig = "Large";

        private EnemyConfig _small;
        private EnemyConfig _medium;
        private EnemyConfig _large;

        private DiContainer _container;

        public EnemyFactory(DiContainer diContainer)
        {
            _container = diContainer;
            Initialize();
        }

        public void Initialize()
        {
            Load();
        }

        public Enemy Create(EnemyType enemyType)
        {
            EnemyConfig config = GetConfig(enemyType);
            Enemy instance = _container.InstantiatePrefabForComponent<Enemy>(config.Prefab);
            instance.Initialize(config.Health, config.Speed);

            return instance;
        }

        private EnemyConfig GetConfig(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Small:
                    return _small;

                case EnemyType.Medium:
                    return _medium;

                case EnemyType.Large:
                    return _large;

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }

        private void Load()
        {
            _small = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, SmallConfig));
            _medium = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, MediumConfig));
            _large = Resources.Load<EnemyConfig>(Path.Combine(ConfigsPath, LargeConfig));
        }
    }
}