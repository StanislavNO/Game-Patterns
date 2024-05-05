using UnityEngine;

namespace Assets.Project2.Task2
{
    public class Unit : MonoBehaviour, IMap
    {
        private StateMachine _stateMachine;

        public void Initialize(EnergyBar energyBar, Transform homePosition, Transform workPosition)
        {
            Transform = transform;

            EnergyBar = energyBar;
            HomePosition = homePosition;
            WorkPosition = workPosition;
            _stateMachine = new StateMachine(this);
        }

        public EnergyBar EnergyBar { get; private set; }
        public Transform Transform { get; private set; }
        public Transform HomePosition { get; private set; }
        public Transform WorkPosition { get; private set; }

        private void Update()
        {
            Debug.Log(EnergyBar.Point);

            if (_stateMachine == null)
                return;

            _stateMachine.Update();
        }
    }
}