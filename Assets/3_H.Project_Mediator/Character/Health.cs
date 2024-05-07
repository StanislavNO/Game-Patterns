using System;

namespace Assets.Project3
{
    public class Health : IHealth
    {
        private const int MIN_POINT = 0;

        private int _defaultDamage;

        public Health(CharacterConfig config)
        {
            _defaultDamage = config.DefaultDamage;
            MaxLifePoint = config.HealthConfig.MaxHealth;
            LifePoint = MaxLifePoint;
        }

        public event Action<int> LivePointChanged;
        public event Action Died;

        public int LifePoint { get; private set; }
        public int MaxLifePoint { get; private set; }

        public void TakeDamage() =>
            TakeDamage(_defaultDamage);

        public void TakeDamage(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if (LifePoint > value)
            {
                LifePoint -= value;
            }
            else
            {
                LifePoint = MIN_POINT;
                Died?.Invoke();
            }

            LivePointChanged?.Invoke(LifePoint);
        }

        public void Heal(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            int drawback = MaxLifePoint - LifePoint;

            if (value > MIN_POINT && value <= drawback)
            {
                LifePoint += value;
            }
            else if (value > drawback)
            {
                LifePoint = MaxLifePoint;
            }
        }

        public void Reset()
        {
            LifePoint = MaxLifePoint;
            LivePointChanged?.Invoke(LifePoint);
        }
    }
}