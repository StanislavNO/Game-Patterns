namespace Assets.Project2.Task2
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}