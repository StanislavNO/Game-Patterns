namespace Assets.Project2.Task3
{
    public class FallingState : AirborneState
    {
        private GroundedChecker _groundedChecker;

        public FallingState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _groundedChecker = character.GroundChecker;
        }

        public override void Enter()
        {
            base.Enter();

            View.StartFalling();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopFalling();
        }

        public override void Update()
        {
            base.Update();

            if (_groundedChecker.IsGround)
            {
                Data.YVelocity = 0;

                if (IsHorizontalInputZero())
                    Switcher.SwitchState<IdlingState>();
                else
                    Switcher.SwitchState<RunningState>();
            }
        }
    }
}