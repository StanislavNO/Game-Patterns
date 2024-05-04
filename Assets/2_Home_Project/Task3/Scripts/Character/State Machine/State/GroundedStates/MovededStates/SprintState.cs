using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class SprintState : MoveState
    {
        private readonly RunningStateConfig _config;

        public SprintState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        protected override void OnSwitchMovePressed(InputAction.CallbackContext context)
        {
            base.OnSwitchMovePressed(context);

            Switcher.SwitchState<WalkingState>();
        }

        protected override void SetSpeed()
        {
            Data.Speed = _config.SprintSpeed;
        }

        protected override void StartView()
        {
            View.StartSprint();
        }

        protected override void StopView()
        {
            View.StopSprint();
        }
    }
}