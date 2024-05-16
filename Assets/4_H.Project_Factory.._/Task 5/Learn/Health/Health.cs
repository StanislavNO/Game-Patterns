using System;

namespace Assets.Project4.Task5.Learn
{
    public class Health : IHealth
    {
        public Health(int maxValue)
        {
            MaxValue = Value = maxValue;
        }

        public event Action Died;
        public event Action<int> Changed;

        public int MaxValue { get; private set; }
        public int Value { get; private set; }

        public void Add(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if (Value + value > MaxValue)
            {
                Value = MaxValue;
            }
            else
            {
                Value += value;
            }

            Changed?.Invoke(Value);
        }

        public void Reduce(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Value -= value;

            if (Value < 0)
            {
                Value = 0;
                Died?.Invoke();
            }

            Changed?.Invoke(Value);
        }
    }
}