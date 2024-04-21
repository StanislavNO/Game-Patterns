using UnityEngine;

namespace Assets.Task4
{
    public class OneColorHandler : VictoryHandler
    {
        private int _enemyCounter;

        public OneColorHandler(EnemyPool enemyPool) : base(enemyPool)
        {
        }

        public override void SetTarget(Colors target)
        {
            Target = target;

            if (target == Colors.Green)
                _enemyCounter = EnemyPool.GreenEnemy;
            else if (target == Colors.Red)
                _enemyCounter = EnemyPool.RedEnemy;
            else
                _enemyCounter = EnemyPool.WhiteEnemy;
        }

        public override void Update(Enemy enemy)
        {
            if (Target == Colors.None)
                return;

            if (enemy.Color != Target)
            {
                Debug.Log("Не тот шар");
                return;
            }

            _enemyCounter--;

            Debug.Log($"Осталось {_enemyCounter} шаров");

            if (_enemyCounter == 0)
                Debug.Log("Победа");
        }
    }
}