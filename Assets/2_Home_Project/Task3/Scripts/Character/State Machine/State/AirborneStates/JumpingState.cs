namespace Assets.Project2.Task3
{
    public class JumpingState : AirborneState
    {
        private JumpingStateConfig _config;

        public JumpingState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.AirborneConfig.JumpingConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.YVelocity = _config.StartYVelocity;

            View.StartJumping();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopJumping();
        }

        public override void Update()
        {
            base.Update();

            if (Data.YVelocity < 0)
                Switcher.SwitchState<FallingState>();
        }
    }
}