using System.Collections;
using UnityEngine;

namespace Assets.Task4
{
    public class OneColorHandler : VictoryHandler
    {
        private Enemy _target;
        private int _enemyCounter;


        public void SetTarget(Enemy enemy)
        {
            _target = enemy;

            InitCounter(enemy);
        }

        private void InitCounter(Enemy enemy)
        {
            if (enemy is GreenMarker)
                _enemyCounter = GreenEnemy;
            else if (enemy is RedMarker)
                _enemyCounter = RedEnemy;
            else
                _enemyCounter = WhiteEnemy;
        }

        public override void Update(Enemy enemy)
        {
            if (_target == null)
                return;

            if (_target.GetType() != enemy.GetType())
            {
                Debug.Log("Не тот шар");
                return;
            }

            _enemyCounter--;

            if (_enemyCounter == 0)
                Debug.Log("Победа");
        }
    }
}