using System;
using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    [Serializable]
    public class HealthConfig
    {
        [field: SerializeField] public int DefaultHealth { get; private set; }
    }
}