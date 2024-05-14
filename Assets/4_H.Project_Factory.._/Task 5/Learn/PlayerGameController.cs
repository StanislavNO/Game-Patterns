using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class PlayerGameController : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private int _powerHealing;

        private Player _player;

        public void Construct(Player player)
        {
            _player = player;
        }

        private void OnValidate()
        {
            if(_damage < 0)
                _damage = 0;

            if(_powerHealing < 0)
                _powerHealing = 0;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
                _player.TakeDamage(_damage);

            if (Input.GetKeyDown(KeyCode.H))
                _player.Heal(_powerHealing);
        }
    }
}