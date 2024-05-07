using UnityEngine;

namespace Assets.Project3
{
    [CreateAssetMenu(fileName = "UnitConfig", menuName = "Configs/UnitConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private HealthConfig _healthConfig;
        [SerializeField] private LevelConfig _levelConfig;
        [SerializeField] private int _defaultDamage;

        public HealthConfig HealthConfig => _healthConfig;
        public LevelConfig LevelConfig => _levelConfig;
        public int DefaultDamage => _defaultDamage;
    }
}