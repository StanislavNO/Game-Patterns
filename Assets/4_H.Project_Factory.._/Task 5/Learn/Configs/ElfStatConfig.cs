using UnityEngine;
using System;

namespace Assets.Project4.Task5.Learn
{
    [Serializable]
    public class ElfStatConfig
    {
        [field: SerializeField] public float HealDuration { get; private set; }
        [field: SerializeField] public int AdditionalHeal {  get; private set; }
        [field: SerializeField] public int TicksCount {  get; private set; }
    }
}