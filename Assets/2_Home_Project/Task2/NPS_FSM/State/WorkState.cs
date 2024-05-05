namespace Assets.Project2.Task2
{
    public class WorkState : IState
    {
        private EnergyBar _energyBar;
        private IStateSwitcher _switcher;

        public WorkState(EnergyBar energyBar, IStateSwitcher switcher)
        {
            _energyBar = energyBar;
            _switcher = switcher;
        }

        public void Enter()
        {
            _energyBar.UsePoint();
        }

        public void Exit()
        {
        }

        public void Update()
        {
            if (_energyBar.Point == 0)
            {
                _switcher.SwitchState<MoveState>();
            }
        }
    }
}
