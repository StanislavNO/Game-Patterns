using UnityEngine;
using System;
using Zenject;

namespace Assets.Project5.DI
{
    public class DesktopInput : IInput, ITickable, IInitializable, IDisposable
    {
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> Drag;

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }
    }
}