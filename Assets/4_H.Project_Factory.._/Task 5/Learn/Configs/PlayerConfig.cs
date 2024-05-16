using UnityEngine;

namespace Assets.Project4.Task5.Learn
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Project_4/PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public HealthConfig Health { get; private set; }
        [field: SerializeField] public ArmorStatConfig ArmorStat { get; private set; }
        [field: SerializeField] public ElfStatConfig ElfStat { get; private set; }
    }
}