using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class WalkingState : MoveState
    {
        private readonly RunningStateConfig _config;

        public WalkingState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        protected override void OnSwitchMovePressed(InputAction.CallbackContext context)
        {
            base.OnSwitchMovePressed(context);

            Switcher.SwitchState<RunningState>();
        }

        protected override void SetSpeed()
        {
            Data.Speed = _config.WalkingSpeed;
        }

        protected override void StartView()
        {
            View.StartWalking();
        }

        protected override void StopView()
        {
            View.StopWalking();
        }
    }
}