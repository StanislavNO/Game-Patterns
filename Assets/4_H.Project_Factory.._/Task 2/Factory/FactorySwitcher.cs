using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public class FactorySwitcher : ITickable
    {
        [SerializeField] private List<EnemySpawner> _spawners;

        private OrkFactory _orkFactory;
        private ElfFactory _elfFactory;

        public FactorySwitcher(OrkFactory orkFactory, ElfFactory elfFactory)
        {
            _orkFactory = orkFactory;
            _elfFactory = elfFactory;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
                SwitchFactory();
        }

        private void SwitchFactory()
        {
            foreach (EnemySpawner spawner in _spawners)
            {
                if (spawner != null)
                    _spawners.Remove(spawner);

                if (spawner.EnemyFactoryType is OrkFactory)
                    spawner.SetFactory(_elfFactory);

                if (spawner.EnemyFactoryType is ElfFactory)
                    spawner.SetFactory(_orkFactory);
            }
        }
    }
}