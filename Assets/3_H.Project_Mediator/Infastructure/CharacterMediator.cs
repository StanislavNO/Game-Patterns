using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project3
{
    public class CharacterMediator : IDisposable
    {
        private readonly HealthBar _healthBar;
        private readonly LevelBar _levelBar;
        private readonly ViewPanel _viewPanel;

        private readonly IHealth _health;
        private readonly ILevelUpper _level;
        private readonly Character _character;

        public CharacterMediator(Character character, IHealth health, ILevelUpper level, HealthBar healthBar, LevelBar levelBar, ViewPanel viewPanel)
        {

            _healthBar = healthBar;
            _levelBar = levelBar;
            _viewPanel = viewPanel;

            _level = level;
            _health = health;
            _character = character;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}