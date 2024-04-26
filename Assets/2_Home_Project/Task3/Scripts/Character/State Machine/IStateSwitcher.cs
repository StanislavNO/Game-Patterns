using System.Collections;
using UnityEngine;

namespace Assets.Project2.Task3
{
    public interface IStateSwitcher 
    {
        void SwitchState<T>() where T : IState;
    }
}