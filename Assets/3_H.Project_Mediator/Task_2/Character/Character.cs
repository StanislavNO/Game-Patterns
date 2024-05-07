using System;
using UnityEngine;

namespace Assets.Project3
{
    public class Character : MonoBehaviour
    {
        private IHealth _health;
        private ILevelCounter _levelCounter;

        public void Construct(IHealth health, ILevelCounter level)
        {
            if (health is null)
                throw new ArgumentNullException(nameof(health));

            if (level is null)
                throw new ArgumentNullException(nameof(level));

            _health = health;
            _levelCounter = level;
        }

        public void Upgrade() =>
            _levelCounter.AddPoint();
    }
}