using System;

namespace Assets.Project3
{
    public interface IHealth
    {
        event Action<int> LivePointChanged;
        event Action Died;

        void TakeDamage();

        void TakeDamage(int value);

        void Heal(int value);

        void Reset();
    }
}