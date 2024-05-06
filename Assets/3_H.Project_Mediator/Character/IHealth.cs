using System;

namespace Assets.Project3
{
    public interface IHealth
    {
        event Action LivePointChanged;

        void TakeDamage(int value);

        void Heal(int value);
    }
}