using UnityEngine;
using System;

[Serializable]
public class RunningStateConfig
{
    [field: SerializeField, Range(0, 10)] public float WalkingSpeed { get; private set; }
    [field: SerializeField, Range(0, 10)] public float DefaultSpeed { get; private set; }
    [field: SerializeField, Range(0, 10)] public float SprintSpeed { get; private set; }
}
