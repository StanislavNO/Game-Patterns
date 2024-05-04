namespace Assets.Project2.Task3
{
    public abstract class MoveState : GroundedState
    {
        protected MoveState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
        }

        public override void Enter()
        {
            base.Enter();

            SetSpeed();
            StartView();
        }

        public override void Exit()
        {
            base.Exit();

            StopView();
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                Switcher.SwitchState<IdlingState>();
        }

        protected abstract void StartView();

        protected abstract void StopView();

        protected abstract void SetSpeed();
    }
}