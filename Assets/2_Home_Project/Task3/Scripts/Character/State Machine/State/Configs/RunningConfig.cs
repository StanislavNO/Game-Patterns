using UnityEngine;
using System;

[Serializable]
public class RunningConfig
{
    [field: SerializeField, Range(0, 10)]
    public float Speed { get; private set; }
}
