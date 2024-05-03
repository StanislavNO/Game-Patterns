using UnityEngine;

namespace Assets.Project2.Task3
{
    public class AirborneState : MovementState
    {
        private readonly AirborneStateConfig _config;

        public AirborneState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
            _config = character.CharacterConfig.AirborneConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.Speed;

            View.StartAirborne();
        }

        public override void Exit()
        { 
            base.Exit();
            
            View.StopAirborne();
        }

        public override void Update()
        {
            base.Update();

            Data.YVelocity -= _config.BaseGravity * Time.deltaTime;
        }
    }
}