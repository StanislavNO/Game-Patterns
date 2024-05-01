namespace Assets.Project2.Task3
{
    public class RunningState : MovementState
    {
        private readonly RunningConfig _config;

        public RunningState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.RunningConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.Speed;
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                Switcher.SwitchState<IdlingState>();
        }
    }
}