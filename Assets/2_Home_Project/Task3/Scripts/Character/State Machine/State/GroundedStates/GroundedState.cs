using UnityEngine.InputSystem;

namespace Assets.Project2.Task3
{
    public class GroundedState : MovementState
    {
        private GroundedChecker _checker;

        public GroundedState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _checker = character.GroundChecker;
        }

        public override void Enter()
        {
            base.Enter();

            View.StartGrounded();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopGrounded();
        }

        public override void Update()
        {
            base.Update();

            if (_checker.IsGround)
                return;

            Switcher.SwitchState<FallingState>();
        }

        protected override void AddInputActionsCallback()
        {
            base.AddInputActionsCallback();

            Input.Movement.Jump.started += OnJumpPressed;
            Input.Movement.SwitchMove.started += OnSwitchMovePressed;
        }

        protected override void RemoveInputActionsCallback()
        {
            base.RemoveInputActionsCallback();

            Input.Movement.Jump.started -= OnJumpPressed;
            Input.Movement.SwitchMove.started -= OnSwitchMovePressed;
        }

        protected virtual void OnSwitchMovePressed(InputAction.CallbackContext context) { }

        private void OnJumpPressed(InputAction.CallbackContext context) =>
            Switcher.SwitchState<JumpingState>();
    }
}