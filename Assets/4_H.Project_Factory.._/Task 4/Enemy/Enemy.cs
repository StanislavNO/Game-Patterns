using System;
using UnityEngine;

namespace Assets.Project4.Task4
{
    public abstract class Enemy : MonoBehaviour
    {
        public event Action<Enemy> Died;

        public void MoveTo(Vector3 position) => transform.position = position;

        public void Kill()
        {
            Died?.Invoke(this);
            Destroy(gameObject);
        }

        public abstract void Accept(IEnemyVisitor visitor);
    }
}