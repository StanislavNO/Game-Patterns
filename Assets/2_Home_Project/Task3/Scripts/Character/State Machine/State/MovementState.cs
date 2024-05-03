using UnityEngine;

namespace Assets.Project2.Task3
{
    public class MovementState : IState
    {
        protected readonly IStateSwitcher Switcher;
        protected readonly CharacterData Data;

        private readonly Character _character;

        public MovementState(IStateSwitcher switcher, Character character, CharacterData data)
        {
            Switcher = switcher;
            _character = character;
            Data = data;
        }

        protected PlayerInput Input => _character.Input;
        protected CharacterController CharacterController => _character.Controller;
        protected CharacterAnimationController View => _character.View;

        private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);
        private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

        public virtual void Enter()
        {
            Debug.Log(GetType());

            AddInputActionsCallback();
        }

        public virtual void Exit()
        {
            RemoveInputActionsCallback();
        }

        public void HandleInput()
        {
            Data.XInput = ReadHorizontalInput();
            Data.XVelocity = Data.XInput * Data.Speed;
        }

        public virtual void Update()
        {
            Vector3 velocity = GetConvertedVelocity();

            CharacterController.Move(velocity * Time.deltaTime);
            _character.transform.rotation = GetRotationFrom(velocity);
        }

        protected virtual void AddInputActionsCallback() { }
        protected virtual void RemoveInputActionsCallback() { }

        protected bool IsHorizontalInputZero() =>
            Data.XInput == 0;

        private Quaternion GetRotationFrom(Vector3 velocity)
        {
            if (velocity.x > 0)
                return TurnRight;

            if (velocity.x < 0)
                return TurnLeft;

            return _character.transform.rotation;
        }

        private Vector3 GetConvertedVelocity() =>
            new Vector3(Data.XVelocity, Data.YVelocity, 0);

        private float ReadHorizontalInput() =>
             Input.Movement.Move.ReadValue<float>();
    }
}