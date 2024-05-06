using System;

namespace Assets.Project3
{
    public interface ILevelUpper
    {
        event Action <int> OnLevelChanged;
    }
}