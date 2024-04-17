using System;
using UnityEngine;

namespace Assets.Task3
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        private int _reputationStep;

        public event Action ReputationChanged;

        public int Reputation { get; private set; }

        private void Awake()
        {
            Reputation = 0;
            _reputationStep = 10;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Reputation += _reputationStep;
                Debug.Log(Reputation + " репутация");

                ReputationChanged?.Invoke();
            }
        }
    }
}