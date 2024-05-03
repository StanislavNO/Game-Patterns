namespace Assets.Project2.Task3
{
    public interface IState 
    {
        void Enter();
        void Exit();
        void Update();
        void HandleInput();
    }
}