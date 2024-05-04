using UnityEngine;

namespace Assets.Project2.Task2
{
    public class Unit : MonoBehaviour
    {
        private StateMachine _stateMachine;

        public void Initialize(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        private void Update()
        {
            if (_stateMachine == null)
                return;
        }
    }
}