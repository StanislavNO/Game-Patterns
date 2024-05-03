using UnityEngine;

namespace Assets.Project2.Task3
{
    [CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private RunningStateConfig _runningStateConfig;
        [SerializeField] private AirborneStateConfig _airborneStateConfig;

        public RunningStateConfig RunningConfig => _runningStateConfig;
        public AirborneStateConfig AirborneConfig => _airborneStateConfig;
    }
}