using System.Collections;
using UnityEngine;

namespace Assets.Project2.Task3
{
    public class IdlingState : MovementState
    {
        public IdlingState(IStateSwitcher switcher, Character character, CharacterData data) : base(switcher, character, data)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = 0;
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                return;

            Switcher.SwitchState<RunningState>();
        }
    }
}