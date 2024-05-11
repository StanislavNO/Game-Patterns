using System.Collections;
using UnityEngine;

namespace Assets.Project4.Task2
{
    [CreateAssetMenu(fileName = "EnemyConfig" , menuName = "Configs/Enemy")]
    public class EnemyConfig : ScriptableObject
    {
        [field: SerializeField] public int DefaultDamage {  get; private set; }
        [field: SerializeField] public ElfConfig ElfConfig {  get; private set; }
        [field: SerializeField] public OrkConfig OrkConfig { get; private set; }
    }
}