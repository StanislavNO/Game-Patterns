using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class Player : MonoBehaviour
    {
        private IHealth _health;

        public void Construct(IHealth health)
        {
            _health = health;
        }

        public void TakeDamage(int damage) => _health.Reduce(damage);

        public void Heal(int value) => _health.Add(value);
    }
}