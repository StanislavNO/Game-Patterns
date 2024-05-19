using UnityEngine;
using System;

namespace Assets.Project5.DI
{
    public class MobileInput : IInput
    {
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> Drag;
    }
}