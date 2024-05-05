using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public class EnergyBar
    {
        private ICoroutineRunner _coroutineRunner;
        private WaitForSeconds _delay;

        public EnergyBar(ICoroutineRunner coroutineRunner)
        {
            MaxPoint = 10;
            Point = MaxPoint;

            _delay = new WaitForSeconds(0.2f);
            _coroutineRunner = coroutineRunner;
        }

        public event Action PointsFilled;
        public event Action PointsOverfed;

        public int MaxPoint { get; private set; }
        public int Point { get; private set; }

        public void FillPoints()
        {
            _coroutineRunner.StartCoroutine(AddPoint());
        }

        public void UsePoint()
        {
            _coroutineRunner.StartCoroutine(DeletePoint());
        }

        private IEnumerator AddPoint()
        {
            while (Point < MaxPoint)
            {
                Point++;
                yield return _delay;
            }

            PointsFilled?.Invoke();
        }

        private IEnumerator DeletePoint()
        {
            while (Point > 0)
            {
                Point--;
                yield return _delay;
            }

            PointsOverfed?.Invoke();
        }
    }
}
