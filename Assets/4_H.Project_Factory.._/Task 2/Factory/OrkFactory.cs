using System;

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
                    return new PaladinOrk();

                case EnemyType.Wizard:
                    return new WizardOrk();

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}