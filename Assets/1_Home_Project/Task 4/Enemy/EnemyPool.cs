using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Task4
{
    public class EnemyPool : MonoBehaviour
    {
        [SerializeField] private List<Enemy> _enemies;

        private void Awake()
        {
            InitColorCounters();
        }

        public int GreenEnemy { get; private set; }
        public int WhiteEnemy { get; private set; }
        public int RedEnemy { get; private set; }

        private void InitColorCounters()
        {
            foreach (Enemy enemy in _enemies)
            {
                if (enemy is GreenMarker)
                    GreenEnemy++;
                else if (enemy is RedMarker)
                    RedEnemy++;
                else
                    WhiteEnemy++;
            }
        }
    }
}