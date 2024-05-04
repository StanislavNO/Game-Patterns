using System.Collections;
using System.ComponentModel;
using UnityEngine;

namespace Assets.Project2.Task2
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Unit _unit;

        private StateMachine _machine;

        private void Awake()
        {
            _machine = new();
            _unit.Initialize(_machine);
        }
    }
}