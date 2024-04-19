using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

namespace Assets.Task4
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private EnemyPool enemyPool;
        [SerializeField] private ScoreManager _scorer;
        [SerializeField] private StartDisplay _startDisplay;
        [SerializeField] private Transform EnemyPointCollection;

        private VictoryHandler _handler;

        private void Awake()
        {
            Instantiate(_startDisplay);


            _startDisplay.Construct(this);

            Instantiate(_scorer);
            _scorer.Construct();

            DontDestroyOnLoad(this);
        }

        public void SetHandler(Type type)
        {
            object instance = Activator.CreateInstance(type);
            _handler = new instance(EnemyPointCollection);
        }
    }
}