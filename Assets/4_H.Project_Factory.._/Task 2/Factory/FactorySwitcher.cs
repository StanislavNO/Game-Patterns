using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public class FactorySwitcher : ITickable
    {
        private List<EnemySpawner> _spawners;

        private OrkFactory _orkFactory;
        private ElfFactory _elfFactory;

        public FactorySwitcher(OrkFactory orkFactory, ElfFactory elfFactory, List<EnemySpawner> spawners)
        {
            _orkFactory = orkFactory;
            _elfFactory = elfFactory;

            _spawners = spawners;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
                SwitchFactory();
        }

        private void SwitchFactory()
        {
            Debug.Log("OnСвитч фабрики");

            for (int i = 0; i < _spawners.Count; i++)
            {
                if (_spawners[i].EnemyFactoryType is OrkFactory)
                {
                    Debug.Log("Свитч фабрики");
                    _spawners[i].SetFactory(_elfFactory);
                }
                else if (_spawners[i].EnemyFactoryType is ElfFactory)
                {
                    Debug.Log("Свитч фабрики");
                    _spawners[i].SetFactory(_orkFactory);
                }
            }
        }
    }
}