using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Project3
{
    public interface ILevel : ILevelUpper, ILevelCounter
    {
    }

    public interface ILevelCounter
    {
        void AddPoint(int value = 0);
    }

    public interface ILevelUpper
    {
        event Action<int> OnLevelChanged;

        void Reset();
    }
}
