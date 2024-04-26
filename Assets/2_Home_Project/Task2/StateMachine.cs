using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public class StateMachine : IStateSwitcher
    {
        public void SwitchState<T>() where T : IState
        {
            throw new System.NotImplementedException();
        }
    }
}