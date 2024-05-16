using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class Mediator
    {
        private readonly Health _health;
        private readonly HealthBar _healthBar;

        public Mediator(Health health, HealthBar healthBar)
        {
            _health = health;
            _healthBar = healthBar;

            _health.Changed += OnHealthChanged;
        }

        private void OnHealthChanged(int health)
        {
            Debug.Log(health);
            _healthBar.WriteHealth(health);
        }
    }
}