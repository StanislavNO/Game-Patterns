using System;
using UnityEngine;

namespace Assets.Project4.Task2
{
    [Serializable]
    public class OrkConfig
    {
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public PaladinOrk PaladinPrefab { get; private set; }
        [field: SerializeField] public WizardOrk WizardPrefab { get; private set; }
    }
}
