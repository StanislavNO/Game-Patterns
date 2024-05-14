using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private HealthBar _healthBar;
        [SerializeField] private PlayerConfig _config;
        [SerializeField] private PlayerGameController _playerController;

        private Health _health;
        private Mediator _mediator;

        private void Awake()
        {
            _health = new(_config.DefaultHealth);
            _healthBar.Construct(_health.MaxValue);
            _mediator = new(_health, _healthBar);

            _player.Construct(_health);
            _playerController.Construct(_player);
        }
    }
}