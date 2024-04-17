using System;
using UnityEngine;

namespace Assets.Task3
{
    [RequireComponent(typeof(Collider))]
    public class Store : MonoBehaviour
    {
        private ISeller _seller;
        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                _seller?.Trade(player.Reputation);
            }
        }

        public void SetSeller(ISeller seller)
        {
            if (seller == null)
                throw new ArgumentNullException(nameof(seller));

            _seller = seller;
        }
    }
}