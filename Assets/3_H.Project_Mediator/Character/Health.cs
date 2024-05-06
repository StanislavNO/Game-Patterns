using System;

namespace Assets.Project3
{
    public class Health : IHealth
    {
        private const int MIN_POINT = 0;

        private int _lifePoint;

        public Health(CharacterConfig config)
        {
            
        }

        public event Action LivePointChanged;

        public int LifePoint => _lifePoint;
        public int MaxLifePoint { get; private set; }

        public void TakeDamage(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if (_lifePoint >= value)
                _lifePoint -= value;
            else
                _lifePoint = MIN_POINT;

            LivePointChanged?.Invoke();
        }

        public void Heal(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            int drawback = MaxLifePoint - _lifePoint;

            if (value > MIN_POINT && value <= drawback)
            {
                _lifePoint += value;
            }
            else if (value > drawback)
            {
                _lifePoint = MaxLifePoint;
            }
        }
    }
}