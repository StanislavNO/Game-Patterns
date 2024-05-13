using System;
using Object = UnityEngine.Object;

namespace Assets.Project4.Task2
{
    public class OrkFactory : EnemyFactory
    {
        public OrkFactory(EnemyConfig config) : base(config)
        {
        }

        public override IEnemy Create(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Paladin:
                    return Object.Instantiate(Config.OrkConfig.PaladinPrefab);

                case EnemyType.Wizard:
                    return Object.Instantiate(Config.OrkConfig.WizardPrefab);

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}