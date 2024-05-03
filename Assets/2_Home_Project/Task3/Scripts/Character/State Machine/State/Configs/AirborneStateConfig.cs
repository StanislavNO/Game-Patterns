using System;
using UnityEngine;

namespace Assets.Project2.Task3
{
    [Serializable]
    public class AirborneStateConfig
    {
        [SerializeField, Range(0, 10)] private float _speed;
        [SerializeField] private JumpingStateConfig _jumpingStateConfig;

        public JumpingStateConfig JumpingConfig => _jumpingStateConfig;
        public float Speed => _speed;

        public float BaseGravity
            => 2f * _jumpingStateConfig.MaxHeight / (_jumpingStateConfig.TimeToReachMaxHeight * _jumpingStateConfig.TimeToReachMaxHeight);
    }
}