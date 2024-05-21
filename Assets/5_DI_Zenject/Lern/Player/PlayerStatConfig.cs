using UnityEngine;

namespace Assets.Project5.DI
{
    [CreateAssetMenu(menuName = "Player/StatsConfig", fileName = "PlayerStatConfig")]
    public class PlayerStatConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 150)]
        public int MaxHealth { get; private set; }
    }
}
