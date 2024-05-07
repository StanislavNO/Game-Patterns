using System;

namespace Assets.Project3
{
    public class CharacterMediator : IDisposable
    {
        private readonly HealthBar _healthBar;
        private readonly LevelBar _levelBar;
        private readonly ViewPanel _viewPanel;

        private Character _character;
        private readonly IHealth _health;
        private readonly ILevelUpper _level;

        public CharacterMediator(Character character, IHealth health, ILevelUpper level, HealthBar healthBar, LevelBar levelBar, ViewPanel viewPanel)
        {
            _healthBar = healthBar;
            _levelBar = levelBar;
            _viewPanel = viewPanel;

            _character = character;
            _level = level;
            _health = health;

            _health.Died += ShowRestartPanel;
            _level.OnLevelChanged += ChangeLevelBar;
            _health.LivePointChanged += ShowCurrencyHealth;

            _viewPanel.Damage.onClick.AddListener(InitDamage);
            _viewPanel.LevelUp.onClick.AddListener(UpgradeCharacter);
            _viewPanel.Restart.onClick.AddListener(RestartLevel);

            RestartLevel();
        }

        public void Dispose()
        {
            _health.Died -= ShowRestartPanel;
            _level.OnLevelChanged -= ChangeLevelBar;
            _health.LivePointChanged -= ShowCurrencyHealth;

            _viewPanel.Damage.onClick.RemoveListener(InitDamage);
            _viewPanel.LevelUp.onClick.RemoveListener(UpgradeCharacter);
            _viewPanel.Restart.onClick.RemoveListener(RestartLevel);
        }

        private void ShowCurrencyHealth(int lifePoint) =>
            _healthBar.WriteHealth(lifePoint);

        private void RestartLevel()
        {
            _viewPanel.HideRestartButton();
            _health.Reset();
            _level.Reset();

            _viewPanel.ShowBaseButtons();
        }

        private void ShowRestartPanel()
        {
            _viewPanel.ShowRestartButton();
            _viewPanel.HideBaseButtons();
        }

        private void InitDamage() =>
            _health.TakeDamage();

        private void UpgradeCharacter() =>
            _character.Upgrade();

        private void ChangeLevelBar(int level) =>
            _levelBar.WriteLevel(level);
    }
}