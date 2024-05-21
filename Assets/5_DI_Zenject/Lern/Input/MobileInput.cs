using System;
using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class MobileInput : IInput, ITickable
    {
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> Drag;

        public void Tick()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        ClickDown?.Invoke(touch.position);
                        break;

                    case TouchPhase.Moved:
                        ClickUp?.Invoke(touch.position);
                        break;

                    case TouchPhase.Ended:
                        Drag?.Invoke(touch.position);
                        break;
                }
            }
        }
    }
}