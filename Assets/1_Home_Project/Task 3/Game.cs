using UnityEngine;

namespace Assets.Task3
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Store _store;

        private void Awake()
        {
            _store.SetSeller(new Florist());
        }

        private void OnEnable()
        {
            _player.ReputationChanged += OnUpdateStore;
        }

        private void OnDisable()
        {
            _player.ReputationChanged -= OnUpdateStore;
        }

        private void OnUpdateStore()
        {
            if (_player.Reputation >= ArmorDealer.MinReputation)
            {
                _store.SetSeller(new ArmorDealer());
                _player.ReputationChanged -= OnUpdateStore;
            }
        }
    }
}