using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class Player : MonoBehaviour
    {
        private Health _health;

        public void Construct(Health health)
        {
            _health = health;
        }

        public void TakeDamage(int damage) => _health.Reduce(damage);

        public void Heal(int value) => _health.Add(value);
    }
}