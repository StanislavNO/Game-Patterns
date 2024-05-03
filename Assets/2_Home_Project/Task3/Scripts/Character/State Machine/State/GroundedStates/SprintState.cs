using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class SprintState : GroundedState
    {
        private readonly RunningStateConfig _config;

        public SprintState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.SprintSpeed;

            View.StartSprint();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopSprint();
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

            Switcher.SwitchState<WalkingState>();
        }
    }
}