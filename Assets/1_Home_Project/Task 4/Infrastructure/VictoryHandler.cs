using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Task4
{
    public abstract class VictoryHandler
    {
        //private Dictionary<Color, int> _enemies = new();

        public event Action GameOver;

        public void Init(Transform enemyPointCollection)
        {
            for (int i = 0; i < enemyPointCollection.childCount; i++)
            {
                if (enemyPointCollection
                    .GetChild(i)
                    .TryGetComponent(out Enemy enemy))
                {
                    //_enemies.Add(enemy);
                }
            }
        }

        public abstract void Update();
    }
}