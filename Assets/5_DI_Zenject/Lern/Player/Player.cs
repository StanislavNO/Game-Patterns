using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class Player : MonoBehaviour, IEnemyTarget
    {
        private int _maxHealth;
        private int _health;

        [Inject]
        private void Construct(PlayerStatConfig config)
        {
            _health = _maxHealth = config.MaxHealth;
            Debug.Log(_health);
        }

        public Vector3 Position => transform.position;

        public void TakeDamage(int value)
        {
            Debug.Log(value);
        }
    }
}
