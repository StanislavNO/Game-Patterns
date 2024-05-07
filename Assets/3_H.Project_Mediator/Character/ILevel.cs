using System;

namespace Assets.Project3
{
    public interface ILevel : ILevelUpper, ILevelCounter
    {
    }

    public interface ILevelCounter
    {
        void AddPoint();
        void AddPoint(int value);
    }

    public interface ILevelUpper
    {
        event Action<int> OnLevelChanged;

        void Reset();
    }
}
