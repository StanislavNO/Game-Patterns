using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public abstract class Paladin : MonoBehaviour, IEnemy
    {
        private int _health = 100;

        [field: SerializeField] protected EnemyConfig Config { get; private set; }
        
        public void MoveTo(Vector3 at)
        {
            transform.position = at;
        }

        public void TakeDamage(int damage)
        {
            _health -= HandleDamage(damage);
        }

        protected abstract int HandleDamage(int damage);
    }
}