﻿using UnityEngine;

namespace Assets.Project2.Task2
{
    public class MoveState : IState
    {
        private Transform _currentPosition;
        private Transform _target;
        private Transform _homePoint;
        private Transform _workPoint;

        private float _step = 1f;

        private EnergyBar _energyBar;
        private IStateSwitcher _switcher;

        public MoveState(IStateSwitcher switcher, IMap map, EnergyBar energyBar, Transform unitTransform)
        {
            _currentPosition = unitTransform;
            _homePoint = map.HomePosition;
            _workPoint = map.WorkPosition;

            _energyBar = energyBar;
            _switcher = switcher;
        }

        public void Enter()
        {
            if (_energyBar.Point == _energyBar.MaxPoint)
                _target = _workPoint;
            else
                _target = _homePoint;
        }

        public void Exit()
        {
            _target = null;
        }

        public void Update()
        {
            MoveToTarget();

            if (_currentPosition.position == _homePoint.position)
                _switcher.SwitchState<ChillState>();

            if (_currentPosition.position == _workPoint.position)
                _switcher.SwitchState<WorkState>();
        }

        private void MoveToTarget()
        {
            Vector3 position = Vector3.MoveTowards(
                _currentPosition.position,
                _target.position,
                _step * Time.deltaTime);

            _currentPosition.position = position;
        }
    }
}