using System;
using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task2
{
    [Serializable]
    public class ElfConfig
    {
        [field: SerializeField] public int Damage {  get; private set; }
        [field: SerializeField] public PaladinElf PaladinPrefab { get; private set;}
        [field: SerializeField] public WizardElf WizardPrefab { get; private set;}
    }
}