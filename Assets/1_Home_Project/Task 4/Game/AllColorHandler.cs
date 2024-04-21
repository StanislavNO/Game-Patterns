using UnityEngine;

namespace Assets.Task4
{
    public class AllColorHandler : VictoryHandler
    {
        private int _enemyCounter;

        public AllColorHandler(EnemyPool enemyPool) : base(enemyPool)
        {
            _enemyCounter =
                EnemyPool.GreenEnemy +
                EnemyPool.RedEnemy +
                EnemyPool.WhiteEnemy;
        }

        public override void Update(Enemy enemy)
        {
            Debug.Log($"Умер {enemy.Color} шар");

            _enemyCounter--;

            if (_enemyCounter == 0)
                Debug.Log("Победа");
        }
    }
}