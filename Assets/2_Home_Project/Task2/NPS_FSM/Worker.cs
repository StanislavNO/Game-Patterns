using UnityEngine;

namespace Assets.Project2.Task2
{
    public class Worker : MonoBehaviour
    {
        private StateMachine _stateMachine;

        public void Initialize(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
    }
}