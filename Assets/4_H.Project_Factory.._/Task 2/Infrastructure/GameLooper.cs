using System;
using System.Collections.Generic;

namespace Assets.Project4.Task2
{
    public class GameLooper
    {
        List<ITickable> _tickables;

        public GameLooper()
        {
            _tickables = new List<ITickable>();
        }

        public void AddTickable(ITickable tickable)
        {
            if (tickable == null)
                throw new NullReferenceException(nameof(tickable));

            _tickables.Add(tickable);
        }

        public void Update()
        {
            if (_tickables == null)
                return;

            foreach (ITickable tickable in _tickables)
                tickable.Update();
        }
    }
}