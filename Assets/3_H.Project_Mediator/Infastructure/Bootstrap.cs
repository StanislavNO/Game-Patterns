using UnityEngine;

namespace Assets.Project3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private CharacterConfig _config;

        [SerializeField] private HealthBar _healthBar;
        [SerializeField] private LevelBar _levelBar;
        [SerializeField] private ViewPanel _viewPanel;

        private CharacterLevel _level;
        private Health _health;
        private CharacterMediator _mediator;

        private void Awake()
        {
            _level = new(_config);
            _health = new(_config);

            _character.Construct(_health, _level);
            _healthBar.Construct(_health.MaxLifePoint);

            _mediator = new(_character, _health, _level, _healthBar, _levelBar, _viewPanel);

            DontDestroyOnLoad(this);
        }

        private void OnDestroy() =>
            _mediator.Dispose();
    }
}