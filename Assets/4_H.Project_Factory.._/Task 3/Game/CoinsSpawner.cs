using Assets.Project2.Task2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Project4.Task3
{
    public class CoinsSpawner : IDeactivator
    {
        private List<Coin> _coins;
        private float _delay = 2f;

        private ICoroutineRunner _coroutineRunner;

        public CoinsSpawner(List<Coin> coins, ICoroutineRunner coroutineRunner)
        {
            _coins = coins;
            _coroutineRunner = coroutineRunner;
        }

        public void Spawn()
        {
            foreach (Coin coin in _coins)
                coin.gameObject.SetActive(true);
        }

        public void Deactivate(Coin coin)
        {
            coin.gameObject.SetActive(false);
            _coroutineRunner.StartCoroutine(DelayAndSpawn(coin));
        }

        private IEnumerator DelayAndSpawn(Coin coin)
        {
            WaitForSeconds delay = new(_delay);

            yield return delay;

            coin.gameObject.SetActive(true);
        }
    }
}