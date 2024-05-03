using System.Collections.Generic;
using System.Linq;

namespace Assets.Project2.Task3
{
    public class CharacterStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currencyState;

        public CharacterStateMachine(Character character)
        {
            CharacterData characterData = new();

            _states = new List<IState>()
            {
                new IdlingState(this, character, characterData),
                new RunningState(this, character, characterData),
                new FallingState(this, character, characterData),
                new JumpingState(this, character, characterData),
                new WalkingState(this, character, characterData),
                new SprintState(this, character, characterData)
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