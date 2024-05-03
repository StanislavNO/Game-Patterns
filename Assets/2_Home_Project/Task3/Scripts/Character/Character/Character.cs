using UnityEngine;

namespace Assets.Project2.Task3
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;
        [SerializeField] private CharacterAnimationController _view;
        [SerializeField] private GroundedChecker _groundedChecker;

        private CharacterStateMachine _stateMachine;

        public PlayerInput Input { get; private set; }
        public CharacterController Controller { get; private set; }
        public CharacterConfig CharacterConfig => _config;
        public CharacterAnimationController View => _view;
        public GroundedChecker GroundChecker => _groundedChecker;

        private void Awake()
        {
            _view.Initialize();
            Input = new();
            Controller = GetComponent<CharacterController>();
            _stateMachine = new(this);
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