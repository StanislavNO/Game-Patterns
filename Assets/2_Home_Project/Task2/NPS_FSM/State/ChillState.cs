namespace Assets.Project2.Task2
{
    public class ChillState : IState
    {
        private EnergyBar _energyBar;
        private IStateSwitcher _switcher;

        public ChillState(EnergyBar energyBar, IStateSwitcher switcher)
        {
            _energyBar = energyBar;
            _switcher = switcher;
        }

        public void Enter()
        {
            _energyBar.FillPoints();
        }

        public void Exit()
        {
        }

        public void Update()
        {
            if (_energyBar.Point == _energyBar.MaxPoint)
            {
                _switcher.SwitchState<MoveState>();
            }
        }
    }
}
