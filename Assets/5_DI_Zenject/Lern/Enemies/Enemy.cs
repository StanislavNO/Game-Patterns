﻿using UnityEngine;
using Zenject;

namespace Assets.Project5.DI
{
    public class Enemy : MonoBehaviour
    {
        private int _health;
        private float _speed;

        private IEnemyTarget _target;

        [Inject]
        private void Construct(IEnemyTarget target)
        {
            _target = target;
        }

        public virtual void Initialize(int health, float speed)
        {
            _health = health;
            _speed = speed;
        }

        private void Update()
        {
            Vector3 direction = (_target.Position - transform.position).normalized;
            transform.Translate(direction * _speed * Time.deltaTime);
        }

        public void MoveTo(Vector3 position)
        {
            transform.position = position;
        }
    }
}