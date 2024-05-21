using System;
using UnityEngine;

namespace Assets.Project5.DI
{
    public class MovementHandler : IDisposable
    {
        private IInput _input;

        public MovementHandler(IInput input)
        {
            _input = input;

            Debug.Log(_input.GetType());

            _input.ClickDown += OnClickDown;
            _input.ClickUp += OnClickUp;
            _input.Drag += OnSwipe;
        }

        public void Dispose()
        {
            _input.ClickDown -= OnClickDown;
            _input.ClickUp -= OnClickUp;
            _input.Drag -= OnSwipe;
        }

        private void OnClickDown(Vector3 position)
        {
            Debug.Log("OnClickDown");
        }

        private void OnClickUp(Vector3 position)
        {
            Debug.Log("OnClickUp");
        }

        private void OnSwipe(Vector3 position)
        {
            Debug.Log("OnSwipe");
        }
    }
}