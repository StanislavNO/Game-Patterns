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
        private IHealth _decorator;
        private Mediator _mediator;

        private void Awake()
        {
            _health = new(_config.Health.DefaultHealth);
            _healthBar.Construct(_health.MaxValue);
            _mediator = new(_health, _healthBar);

            _decorator = DecorateHealth();

            _player.Construct(_decorator);
            _playerController.Construct(_player);
        }

        private IHealth DecorateHealth()
        {
            IHealth health =
                new ElfHealth(
                new ArmorHealth(_health, _config.ArmorStat.Armor),
                this, _config);

            return health;
        }
    }
}