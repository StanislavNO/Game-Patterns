using System;
using UnityEngine;

namespace Assets.Project3
{
    [Serializable]
    public class HealthConfig
    {
        [field: SerializeField][Range(1, 100)] private int _maxHealth;

        public int MaxHealth => _maxHealth;
    }
}