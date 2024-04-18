using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Task4
{
    public abstract class VictoryHandler
    {
        private List<Enemy> _enemies = new();

        public void Init(Transform enemyPointCollection)
        {
            for (int i = 0; i < enemyPointCollection.childCount; i++)
            {
                Enemy enemy = enemyPointCollection.GetChild(i).GetComponent<Enemy>();

                _enemies.Add(enemy);
            }
        }
    }
}