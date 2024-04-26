using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Project2.Task3
{
    public class CharacterStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currencyState;

        public CharacterStateMachine()
        {
            _states = new List<IState>()
            {

            };

            _currencyState = _states[0];
            _currencyState.Enter();
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);

            _currencyState.Exit();
            _currencyState = state;
            _currencyState.Enter();
        }

        public void HandleInput()
        {
            _currencyState.HandleInput();
        }

        public void Update()
        {
            _currencyState.Update();
        }
    }
}