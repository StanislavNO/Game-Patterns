using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public class StateMachine : IStateSwitcher
    {
        private List<IState> _states;

        private IState _currencyState;

        public StateMachine()
        {
            _states = new List<IState>()
            {
                
            };

            _currencyState = _states[0];
            _currencyState.Enter();
        }

        public void SwitchState<T>() where T : IState
        {
            throw new System.NotImplementedException();
        }
    }
}