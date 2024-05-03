using System;
using UnityEngine;

namespace Assets.Project2.Task3
{
    [Serializable]
    public class JumpingStateConfig
    {
        [SerializeField, Range(0, 10)] private float _maxHeight;
        [SerializeField, Range(0, 10)] private float _timeToReachMaxHeight;

        public float StartYVelocity => 2f * _maxHeight / _timeToReachMaxHeight ;
        public float MaxHeight => _maxHeight;
        public float TimeToReachMaxHeight => _timeToReachMaxHeight;
    }
}