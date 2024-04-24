using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : IStateSwitcher
{
    public void SwitchState<T>() where T : IState
    {
        throw new System.NotImplementedException();
    }
}
