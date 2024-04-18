using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Task4
{
    public class EntryPoint : MonoBehaviour
    {
        //[SerializeField] private VictoryHandler handler;
        [SerializeField] private StartDisplay _startDisplay;
        [SerializeField] private Transform EnemyPointCollection;

        private VictoryHandler _handler;

        private void Awake()
        {
            Instantiate(_startDisplay);
            _startDisplay.Construct(this);

            DontDestroyOnLoad(this);
        }

        public void SetHandler(VictoryHandler handler)
        {
            _handler = handler;
            _handler.Init(EnemyPointCollection);
        }
    }
}