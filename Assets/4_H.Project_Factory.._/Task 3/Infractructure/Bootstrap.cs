using Assets.Project2.Task2;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task3
{
    public class Bootstrap : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private List<Coin> _coins;

        private CoinsSpawner _coinsSpawner;

        private void Awake()
        {
            _coinsSpawner = new(_coins, this);

            InitCoins();
        }

        private void Start()
        {
            _coinsSpawner.Spawn();
        }

        private void InitCoins()
        {
            foreach (Coin coin in _coins)
            {
                coin.Construct(_coinsSpawner);
            }
        }
    }
}