using System;

namespace Assets.Project4.Task5.Learn
{
    public class ArmorHealth : IHealth
    {
        private IHealth _healthStat;
        private int _armor;

        public ArmorHealth(IHealth healthStat, int armor)
        {
            _healthStat = healthStat;
            _armor = armor;
        }

        public int MaxValue => _healthStat.MaxValue;
        public int Value => _healthStat.Value;

        public void Add(int value) => _healthStat.Add(value);

        public void Reduce(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            value -= _armor;
            value = Clamp(value);

            _healthStat.Reduce(value);
        }

        private int Clamp(int value)
        {
            if (value < 0)
                value = 0;

            return value;
        }
    }
}