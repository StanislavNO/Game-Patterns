using UnityEngine;

namespace Assets.Project2.Task3
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        private PlayerInput _input;
        private CharacterController _controller;
        private CharacterStateMachine _stateMachine;

        public PlayerInput Input => _input;
        public CharacterController Controller => _controller;

        private void Awake()
        {
            _input = new();
            _stateMachine = new();
            _controller = GetComponent<CharacterController>();
        }

        private void OnEnable()
        {
            _input.Enable();
        }

        private void OnDisable()
        {
            _input.Disable();
        }

        private void Update()
        {
            _stateMachine.Update();
            _stateMachine.HandleInput();
        }
    }
}