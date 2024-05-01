using System.Collections;
using UnityEngine;

namespace Assets.Project2.Task3
{
    [CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [field: SerializeField]
        public RunningConfig RunningConfig { get; private set; }
    }
}