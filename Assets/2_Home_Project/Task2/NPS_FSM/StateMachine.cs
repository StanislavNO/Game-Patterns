using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public class StateMachine : IStateSwitcher
    {
        private List<IState> _states;

        private IState _currencyState;

        public StateMachine(Unit unit)
        {
            _states = new List<IState>()
            {
                new MoveState(this, unit, unit.EnergyBar, unit.Transform),
                new ChillState(unit.EnergyBar, this),
                new WorkState(unit.EnergyBar, this)
            };

            _currencyState = _states[0];
            _currencyState.Enter();
        }

        public void Update()
        {
            _currencyState.Update();
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);

            _currencyState.Exit();
            _currencyState = state;
            _currencyState.Enter();

            Debug.Log("Switch");
        }
    }
}