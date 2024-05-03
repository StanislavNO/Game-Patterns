using Unity.VisualScripting;

namespace Assets.Project2.Task2
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}