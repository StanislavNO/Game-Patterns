using System.Collections;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class WalkingState : RunningState
    {
        private readonly RunningStateConfig _config;

        public WalkingState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.WalkingSpeed;

            View.StartWalking();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopWalking();
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                Switcher.SwitchState<IdlingState>();
        }

        protected override void OnSwitchMovePressed(InputAction.CallbackContext context)
        {
            base.OnSwitchMovePressed(context);

            Switcher.SwitchState<RunningState>();
        }
    }
}