using System;
using UnityEngine;

namespace Assets.Project5.DI
{
    public interface IInput
    {
        event Action<Vector3> ClickUp;
        event Action<Vector3> ClickDown;
        event Action<Vector3> Drag;
    }
}