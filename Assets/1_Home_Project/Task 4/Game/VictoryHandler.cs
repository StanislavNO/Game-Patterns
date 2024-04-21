using UnityEngine;

namespace Assets.Task4
{
    public abstract class VictoryHandler
    {
        protected Colors Target;

        public VictoryHandler(EnemyPool enemyPool)
        {
            EnemyPool = enemyPool;

            Target = new Colors();
            Target = Colors.None;
        }

        public EnemyPool EnemyPool { get; private set; }

        public abstract void Update(Enemy enemy);

        public virtual void SetTarget(Colors color)
        {
            Target = color;
        }
    }
}