using System;
using Object = UnityEngine.Object;

namespace Assets.Project4.Task2
{
    public class ElfFactory : EnemyFactory
    {
        public ElfFactory(EnemyConfig config) : base(config)
        {
        }

        public override IEnemy Create(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return Object.Instantiate(Config.ElfConfig.PaladinPrefab);

                case EnemyType.Wizard:
                    return Object.Instantiate(Config.ElfConfig.WizardPrefab);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}