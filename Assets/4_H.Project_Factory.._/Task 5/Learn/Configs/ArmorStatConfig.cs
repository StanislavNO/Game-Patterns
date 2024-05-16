using System;
using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    [Serializable]
    public class ArmorStatConfig
    {
        [field: SerializeField] public int Armor { get; private set; }
    }
}