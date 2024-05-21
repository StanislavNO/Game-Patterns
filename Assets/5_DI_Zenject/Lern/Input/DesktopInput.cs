using UnityEngine;
using System;
using Zenject;

namespace Assets.Project5.DI
{
    public class DesktopInput : IInput, ITickable
    {
        private const int LeftMouseButton = 0;

        private bool _isDragging;
        private Vector3 _previousMousePosition;

        public event Action<Vector3> ClickUp;
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> Drag;

        public void Tick()
        {
            ProcessClickUp();
            ProcessClickDown();
            ProcessSwipe();
        }

        private void ProcessSwipe()
        {
            if (_isDragging == false)
                return;

            Vector3 mousePosition = Input.mousePosition;

            if (mousePosition != _previousMousePosition)
                Drag?.Invoke(mousePosition);

            _previousMousePosition = mousePosition;
        }

        private void ProcessClickDown()
        {
            if (Input.GetMouseButtonDown(LeftMouseButton))
            {
                ClickDown?.Invoke(Input.mousePosition);

                _isDragging = true;
                _previousMousePosition = Input.mousePosition;
            }
        }

        private void ProcessClickUp()
        {
            if (Input.GetMouseButtonUp(LeftMouseButton))
            {
                ClickUp?.Invoke(Input.mousePosition);

                _isDragging = false;
            }
        }
    }
}