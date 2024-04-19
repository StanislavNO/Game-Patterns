using System.Collections;
using UnityEngine;

namespace Assets.Task4
{
    public class AllColorHandler : VictoryHandler
    {
        private int _enemies;

        public AllColorHandler(Transform enemyPointCollection) : base(enemyPointCollection)
        {
            _enemies = GreenEnemy + WhiteEnemy + RedEnemy;
        }

        public override void Update(Enemy enemy)
        {
            _enemies--;
            Debug.Log($"Убит {enemy}");

            if (_enemies == 0)
                Debug.Log("Победа");
        }
    }
}