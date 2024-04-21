using UnityEngine;
using System;

namespace Assets.Task4
{
    public class PlayerInput : MonoBehaviour
    {
        private Ray _ray;
        private RaycastHit _hit;

        public event Action<Enemy> EnemyDied;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShotRay();
            }
        }

        private void ShotRay()
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out _hit))
            {
                if (_hit.collider.TryGetComponent(out Enemy enemy))
                {
                    EnemyDied?.Invoke(enemy);
                    enemy.Die();
                }
            }
        }
    }
}