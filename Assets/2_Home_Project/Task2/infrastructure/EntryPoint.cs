using UnityEngine;

namespace Assets.Project2.Task2
{
    public class EntryPoint : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private Unit _unit;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private Transform _workPoint;

        private EnergyBar _energyBar;

        private void Awake()
        {
            _energyBar = new(this);

            _unit.Initialize(_energyBar, _homePoint, _workPoint);
        }
    }
}