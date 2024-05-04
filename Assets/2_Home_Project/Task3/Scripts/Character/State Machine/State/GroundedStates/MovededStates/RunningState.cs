using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class RunningState : MoveState
    {
        private readonly RunningStateConfig _config;

        public RunningState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        protected override void OnSwitchMovePressed(InputAction.CallbackContext context)
        {
            base.OnSwitchMovePressed(context);

            Switcher.SwitchState<SprintState>();
        }

        protected override void SetSpeed()
        {
            Data.Speed = _config.DefaultSpeed;
        }

        protected override void StartView()
        {
            View.StartRunning();
        }

        protected override void StopView()
        {
            View.StopRunning();
        }
    }
}