using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task2
{
    public abstract class Wizard : MonoBehaviour, IEnemy
    {
        [field: SerializeField] protected EnemyConfig Config { get; private set; }

        public void MoveTo(Vector3 at)
        {
            transform.position = at;
        }

        public void Attack()
        {
            int damage = GetDamage();

            Debug.Log(damage);
        }

        protected abstract int GetDamage();
    }
}