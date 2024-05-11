using System;

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
                    return new PaladinElf();

                case EnemyType.Wizard:
                    return new WizardElf();

                default:
                    throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}