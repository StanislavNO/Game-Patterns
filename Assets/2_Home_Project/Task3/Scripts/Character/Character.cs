using UnityEngine;

namespace Assets.Project2.Task3
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;

        private CharacterStateMachine _stateMachine;

        public PlayerInput Input { get; private set; }
        public CharacterController Controller { get; private set; }
        public CharacterConfig CharacterConfig => _config;

        private void Awake()
        {
            Input = new();
            _stateMachine = new(this);
            Controller = GetComponent<CharacterController>();
        }

        private void OnEnable()
        {
            Input.Enable();
        }

        private void OnDisable()
        {
            Input.Disable();
        }

        private void Update()
        {
            _stateMachine.HandleInput();
            _stateMachine.Update();
        }
    }
}